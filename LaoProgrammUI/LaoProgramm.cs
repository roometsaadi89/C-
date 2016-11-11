using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaoProgrammLibrary;

namespace LaoProgrammUI
{
    public partial class LaoProgramm : Form
    {

        // me soovime oma windowsfomsis ligipääsu Store klassi venbdori ja items listile, seega deklareerime selle klassi:
        private Store _store = new Store();
        // ja et nüüd ühendada data UIga, windows formsi puhul me vajame bindingsource
        BindingSource itemsBinding = new BindingSource();
        //kuna me soovime lisada itemeid uude listi, Cart listi, siis peame selle siin tegema. 
        private List<Item> CartList = new List<Item>();
        //loome bindingsource ka itemcart jaoks
        BindingSource cartBinding = new BindingSource();
        //ja loome ka vendorilisti bindingsource
        BindingSource vendorBinding = new BindingSource();
        //et storeprofitit näidata, peame tekitama selle siia
        private decimal storeProfit = 0;


        //ctor
        public LaoProgramm()
        {
            //meie kood peab alati pärast seda olema
            InitializeComponent();
            SetupData();


            #region ItemListBindinguprotseduur
            /*Bindime oma itemid:
            //itemsBinding.DataSource = _store.Items;
            //nüüd aga tahame kuvada ainult neid itemeid, mis ei ole müüdud. Siiski peame
            // selle kirjutama alla ka, kunja siin me seda kasutame ainult esimene kord, kui 
            // programmi avame.

            1) */
            itemsBinding.DataSource = _store.Items.Where(x => x.Sold == false).ToList();
            /*ja nüüd paneme need asjad meie items listboxi
             * 
            2)*/
            lBoxItems.DataSource = itemsBinding;
           
            //paneme data listboxi
            LboxVendor.DataSource = vendorBinding;

            /* ja nüüd displayme need ja lisame propertied, mida me tahame displayda
            //selleks loome uue properti ,et kaks asja koos : item name ja price koos 
            //displayda.

            3)*/
            lBoxItems.DisplayMember = "Display";
            lBoxItems.ValueMember = "Display";

            #endregion
            #region CartListiBindinguprotseduur
            //teeme sama bindinasja läbi ka Cart listiga. 
            cartBinding.DataSource = CartList;
            lBoxCart.DataSource = cartBinding;
            lBoxCart.DisplayMember = "Display";
            lBoxCart.ValueMember = "Display";
            #endregion region
            #region VendorListiBinding

            vendorBinding.DataSource = _store.Vendors;
            LboxVendor.DataSource = vendorBinding;
            LboxVendor.DisplayMember = "Display2";
            LboxVendor.ValueMember = "Display2";

            #endregion region
        }

     
        private void SetupData()
        {
            /*initsialiseerimine Vendors Listi. aga seda on mõttetu teha
            siin meetodi sees, kuna siis peaksike seda iga kord uue meetodi sees 
            tegema hakkama. seega lähme parem store klassi ja teeme konstruktori. */
            //_store.Vendors = new List<Vendor>();
          // initsialiseerimien ja samal ajal anname ka väärtuse vendorile
            _store.Vendors.Add(new Vendor {FirstName = "Peeter", LastName = "Pakiraam"});
            _store.Vendors.Add(new Vendor { FirstName = "Jaan", LastName = "Pakiraam" });

            //lets create some items
            _store.Items.Add(new Item {
                Name = "Dell 200",
                Desctiption = "protsessor 5000",
                Price = 4.50M,
                Owner = _store.Vendors[0] });
            _store.Items.Add(new Item
            {
                Name = "Dell 300",
                Desctiption = "protsessor 6000",
                Price = 9.50M,
                Owner = _store.Vendors[1]
            });
            _store.Items.Add(new Item
            {
                Name = "Dell 440",
                Desctiption = "protsessor 9000",
                Price = 14.50M,
                Owner = _store.Vendors[0]
            });

            _store.Name = "Roometikaubad";

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            /* 
             1)Selgita, mis on valitud item listis
             2)copy item cart listi
             */
             //see päris keeruline, loome ühe uue objekti ja teame, et see
             //on item tüüpi, kuna meil on listboxis itemid. 
            Item selectedItem = (Item) lBoxItems.SelectedItem;
            
            
            CartList.Add(selectedItem);
           cartBinding.ResetBindings(false);
           
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            // tahame märkida itemi "sold"
            // puhastame cart listi

            // käime foreachiga selle listi läbi ja ütleme ,et item.sold on true

            foreach (Item item in cartBinding)
            {
                
                item.Sold = true;
                // kui teeme myygi, siis arvutab, palju peame kauba omanikule maksma
                item.Owner.PaymentDue += (decimal)item.Owner.Comission*item.Price;
                // ja iga kord, kui toimub ost, siis me arvutame ümber, mis meie store
                //profit hetkel on. 
                storeProfit += (decimal) item.Price - item.Owner.PaymentDue;
                //storeProfit += (1 - (decimal) item.Owner.Comission)*item.Price;
            }

            //puhastame listi
            CartList.Clear();

            //peame uuendama items listi ja ütleme, mis seal olem peab. ja allpool refreshime. 
            itemsBinding.DataSource = _store.Items.Where(x => x.Sold == false).ToList();


            labelStoreMoney.Text = string.Format("{0}€", storeProfit);

            //uuendame
            cartBinding.ResetBindings(false);
            //seda uuendame, kuna me tahame, et item listis ei oleks neid itemeid, mis müüdud. selleks
            // tegime üles lambdaavaldise, ehk filtri, et kuvaks ainult mittemüüdud itemeid ja
            //pärats seda, kui ostetakse item, me peame seda listi ju uuendama
            itemsBinding.ResetBindings(false);
            //uuendame ka vendorsi infot
            vendorBinding.ResetBindings(false);

        }
    }
   
}
