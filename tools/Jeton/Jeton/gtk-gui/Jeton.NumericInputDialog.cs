// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Jeton {
    
    
    public partial class NumericInputDialog {
        
        private Gtk.VBox vbox2;
        
        private Gtk.Label infoLabel;
        
        private Gtk.Label valueLabel;
        
        private Gtk.Table ButtonTable;
        
        private Gtk.HSeparator hseparator4;
        
        private Gtk.Button button354;
        
        private Gtk.Button button353;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Jeton.NumericInputDialog
            this.Name = "Jeton.NumericInputDialog";
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.BorderWidth = ((uint)(8));
            this.HasSeparator = false;
            // Internal child Jeton.NumericInputDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            // Container child vbox2.Gtk.Box+BoxChild
            this.infoLabel = new Gtk.Label();
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.LabelProp = Mono.Unix.Catalog.GetString("Zahleneingabe");
            this.infoLabel.UseMarkup = true;
            this.vbox2.Add(this.infoLabel);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.infoLabel]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            w2.Padding = ((uint)(4));
            // Container child vbox2.Gtk.Box+BoxChild
            this.valueLabel = new Gtk.Label();
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.LabelProp = Mono.Unix.Catalog.GetString("<span size=\"xx-large\"><b>0.00€</b></span>");
            this.valueLabel.UseMarkup = true;
            this.vbox2.Add(this.valueLabel);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox2[this.valueLabel]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            w3.Padding = ((uint)(8));
            // Container child vbox2.Gtk.Box+BoxChild
            this.ButtonTable = new Gtk.Table(((uint)(4)), ((uint)(3)), true);
            this.ButtonTable.Name = "ButtonTable";
            this.ButtonTable.RowSpacing = ((uint)(6));
            this.ButtonTable.ColumnSpacing = ((uint)(6));
            this.ButtonTable.BorderWidth = ((uint)(6));
            this.vbox2.Add(this.ButtonTable);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.ButtonTable]));
            w4.Position = 2;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hseparator4 = new Gtk.HSeparator();
            this.hseparator4.HeightRequest = 14;
            this.hseparator4.Name = "hseparator4";
            this.vbox2.Add(this.hseparator4);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox2[this.hseparator4]));
            w5.Position = 3;
            w5.Expand = false;
            w5.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w6.Position = 0;
            // Internal child Jeton.NumericInputDialog.ActionArea
            Gtk.HButtonBox w7 = this.ActionArea;
            w7.Name = "dialog1_ActionArea";
            w7.Spacing = 6;
            w7.BorderWidth = ((uint)(5));
            w7.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button354 = new Gtk.Button();
            this.button354.CanFocus = true;
            this.button354.Name = "button354";
            this.button354.UseStock = true;
            this.button354.UseUnderline = true;
            this.button354.Label = "gtk-cancel";
            this.AddActionWidget(this.button354, -6);
            Gtk.ButtonBox.ButtonBoxChild w8 = ((Gtk.ButtonBox.ButtonBoxChild)(w7[this.button354]));
            w8.Expand = false;
            w8.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button353 = new Gtk.Button();
            this.button353.WidthRequest = 120;
            this.button353.HeightRequest = 80;
            this.button353.CanFocus = true;
            this.button353.Name = "button353";
            this.button353.UseStock = true;
            this.button353.UseUnderline = true;
            this.button353.Label = "gtk-ok";
            this.AddActionWidget(this.button353, -5);
            Gtk.ButtonBox.ButtonBoxChild w9 = ((Gtk.ButtonBox.ButtonBoxChild)(w7[this.button353]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 424;
            this.DefaultHeight = 300;
            this.Show();
        }
    }
}
