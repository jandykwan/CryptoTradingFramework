﻿namespace CryptoMarketClient {
    partial class TrailingSettinsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.BuyPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.trailingSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TotalSpendInBaseCurrencyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StopLossPricePercentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TakeProfitPercentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForBuyPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTotalSpendInBaseCurrency = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStopLossPricePercent = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTakeProfitPercent = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuyPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailingSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalSpendInBaseCurrencyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopLossPricePercentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TakeProfitPercentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBuyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTotalSpendInBaseCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStopLossPricePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTakeProfitPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Appearance.Control.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLayoutControl1.Appearance.Control.Options.UseFont = true;
            this.dataLayoutControl1.Controls.Add(this.BuyPriceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TotalSpendInBaseCurrencyTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StopLossPricePercentTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TakeProfitPercentTextEdit);
            this.dataLayoutControl1.Controls.Add(this.simpleButton1);
            this.dataLayoutControl1.Controls.Add(this.simpleButton2);
            this.dataLayoutControl1.DataSource = this.trailingSettingsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(690, 451);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // BuyPriceTextEdit
            // 
            this.BuyPriceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trailingSettingsBindingSource, "BuyPrice", true));
            this.BuyPriceTextEdit.Location = new System.Drawing.Point(311, 24);
            this.BuyPriceTextEdit.Name = "BuyPriceTextEdit";
            this.BuyPriceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.BuyPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.BuyPriceTextEdit.Properties.Mask.EditMask = "f8";
            this.BuyPriceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.BuyPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.BuyPriceTextEdit.Size = new System.Drawing.Size(355, 52);
            this.BuyPriceTextEdit.StyleController = this.dataLayoutControl1;
            this.BuyPriceTextEdit.TabIndex = 4;
            // 
            // trailingSettingsBindingSource
            // 
            this.trailingSettingsBindingSource.DataSource = typeof(CryptoMarketClient.Common.TrailingSettings);
            // 
            // AmountTextEdit
            // 
            this.AmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trailingSettingsBindingSource, "Amount", true));
            this.AmountTextEdit.Location = new System.Drawing.Point(311, 84);
            this.AmountTextEdit.Name = "AmountTextEdit";
            this.AmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AmountTextEdit.Properties.Mask.EditMask = "f8";
            this.AmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountTextEdit.Size = new System.Drawing.Size(355, 52);
            this.AmountTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountTextEdit.TabIndex = 5;
            // 
            // TotalSpendInBaseCurrencyTextEdit
            // 
            this.TotalSpendInBaseCurrencyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trailingSettingsBindingSource, "TotalSpendInBaseCurrency", true));
            this.TotalSpendInBaseCurrencyTextEdit.Location = new System.Drawing.Point(311, 144);
            this.TotalSpendInBaseCurrencyTextEdit.Name = "TotalSpendInBaseCurrencyTextEdit";
            this.TotalSpendInBaseCurrencyTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TotalSpendInBaseCurrencyTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TotalSpendInBaseCurrencyTextEdit.Properties.Mask.EditMask = "f8";
            this.TotalSpendInBaseCurrencyTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TotalSpendInBaseCurrencyTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TotalSpendInBaseCurrencyTextEdit.Size = new System.Drawing.Size(355, 52);
            this.TotalSpendInBaseCurrencyTextEdit.StyleController = this.dataLayoutControl1;
            this.TotalSpendInBaseCurrencyTextEdit.TabIndex = 6;
            // 
            // StopLossPricePercentTextEdit
            // 
            this.StopLossPricePercentTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trailingSettingsBindingSource, "StopLossPricePercent", true));
            this.StopLossPricePercentTextEdit.Location = new System.Drawing.Point(311, 204);
            this.StopLossPricePercentTextEdit.Name = "StopLossPricePercentTextEdit";
            this.StopLossPricePercentTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.StopLossPricePercentTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.StopLossPricePercentTextEdit.Properties.Mask.EditMask = "P";
            this.StopLossPricePercentTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.StopLossPricePercentTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.StopLossPricePercentTextEdit.Size = new System.Drawing.Size(355, 52);
            this.StopLossPricePercentTextEdit.StyleController = this.dataLayoutControl1;
            this.StopLossPricePercentTextEdit.TabIndex = 7;
            // 
            // TakeProfitPercentTextEdit
            // 
            this.TakeProfitPercentTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trailingSettingsBindingSource, "TakeProfitPercent", true));
            this.TakeProfitPercentTextEdit.Location = new System.Drawing.Point(311, 264);
            this.TakeProfitPercentTextEdit.Name = "TakeProfitPercentTextEdit";
            this.TakeProfitPercentTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.TakeProfitPercentTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TakeProfitPercentTextEdit.Properties.Mask.EditMask = "P";
            this.TakeProfitPercentTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TakeProfitPercentTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TakeProfitPercentTextEdit.Size = new System.Drawing.Size(355, 52);
            this.TakeProfitPercentTextEdit.StyleController = this.dataLayoutControl1;
            this.TakeProfitPercentTextEdit.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup1.Size = new System.Drawing.Size(690, 451);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForBuyPrice,
            this.ItemForAmount,
            this.ItemForTotalSpendInBaseCurrency,
            this.ItemForStopLossPricePercent,
            this.ItemForTakeProfitPercent,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup2.Size = new System.Drawing.Size(650, 411);
            // 
            // ItemForBuyPrice
            // 
            this.ItemForBuyPrice.Control = this.BuyPriceTextEdit;
            this.ItemForBuyPrice.Location = new System.Drawing.Point(0, 0);
            this.ItemForBuyPrice.Name = "ItemForBuyPrice";
            this.ItemForBuyPrice.Size = new System.Drawing.Size(650, 60);
            this.ItemForBuyPrice.Text = "Buy Price";
            this.ItemForBuyPrice.TextSize = new System.Drawing.Size(281, 25);
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountTextEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 60);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(650, 60);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextSize = new System.Drawing.Size(281, 25);
            // 
            // ItemForTotalSpendInBaseCurrency
            // 
            this.ItemForTotalSpendInBaseCurrency.Control = this.TotalSpendInBaseCurrencyTextEdit;
            this.ItemForTotalSpendInBaseCurrency.Location = new System.Drawing.Point(0, 120);
            this.ItemForTotalSpendInBaseCurrency.Name = "ItemForTotalSpendInBaseCurrency";
            this.ItemForTotalSpendInBaseCurrency.Size = new System.Drawing.Size(650, 60);
            this.ItemForTotalSpendInBaseCurrency.Text = "Total Spend In Base Currency";
            this.ItemForTotalSpendInBaseCurrency.TextSize = new System.Drawing.Size(281, 25);
            // 
            // ItemForStopLossPricePercent
            // 
            this.ItemForStopLossPricePercent.Control = this.StopLossPricePercentTextEdit;
            this.ItemForStopLossPricePercent.Location = new System.Drawing.Point(0, 180);
            this.ItemForStopLossPricePercent.Name = "ItemForStopLossPricePercent";
            this.ItemForStopLossPricePercent.Size = new System.Drawing.Size(650, 60);
            this.ItemForStopLossPricePercent.Text = "Stop Loss Price Percent";
            this.ItemForStopLossPricePercent.TextSize = new System.Drawing.Size(281, 25);
            // 
            // ItemForTakeProfitPercent
            // 
            this.ItemForTakeProfitPercent.Control = this.TakeProfitPercentTextEdit;
            this.ItemForTakeProfitPercent.Location = new System.Drawing.Point(0, 240);
            this.ItemForTakeProfitPercent.Name = "ItemForTakeProfitPercent";
            this.ItemForTakeProfitPercent.Size = new System.Drawing.Size(650, 60);
            this.ItemForTakeProfitPercent.Text = "Take Profit Percent";
            this.ItemForTakeProfitPercent.TextSize = new System.Drawing.Size(281, 25);
            // 
            // simpleButton1
            // 
            this.simpleButton1.AutoWidthInLayoutControl = true;
            this.simpleButton1.Location = new System.Drawing.Point(363, 371);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.simpleButton1.Size = new System.Drawing.Size(136, 56);
            this.simpleButton1.StyleController = this.dataLayoutControl1;
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "OK";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(339, 335);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 16, 16, 4);
            this.layoutControlItem1.Size = new System.Drawing.Size(156, 76);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.AutoWidthInLayoutControl = true;
            this.simpleButton2.Location = new System.Drawing.Point(519, 371);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.simpleButton2.Size = new System.Drawing.Size(147, 56);
            this.simpleButton2.StyleController = this.dataLayoutControl1;
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Cancel";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton2;
            this.layoutControlItem2.Location = new System.Drawing.Point(495, 335);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 16, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(155, 76);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 300);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(339, 111);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(339, 300);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(311, 35);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // TrailingSettinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 451);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "TrailingSettinsForm";
            this.Text = "Trailing Settings";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuyPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailingSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalSpendInBaseCurrencyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopLossPricePercentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TakeProfitPercentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBuyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTotalSpendInBaseCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStopLossPricePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTakeProfitPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource trailingSettingsBindingSource;
        private DevExpress.XtraEditors.TextEdit BuyPriceTextEdit;
        private DevExpress.XtraEditors.TextEdit AmountTextEdit;
        private DevExpress.XtraEditors.TextEdit TotalSpendInBaseCurrencyTextEdit;
        private DevExpress.XtraEditors.TextEdit StopLossPricePercentTextEdit;
        private DevExpress.XtraEditors.TextEdit TakeProfitPercentTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBuyPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTotalSpendInBaseCurrency;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStopLossPricePercent;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTakeProfitPercent;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}