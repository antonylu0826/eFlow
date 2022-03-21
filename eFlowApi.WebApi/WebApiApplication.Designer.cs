namespace eFlowApi.WebApi {
    partial class eFlowApiWebApiApplication {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            //this.module2 = new DevExpress.ExpressApp.WebApi.SystemModule.SystemWebApiModule();
            this.module3 = new eFlowApi.Module.eFlowApiModule();
            this.conditionalAppearanceModule = new DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule();
            this.validationModule = new DevExpress.ExpressApp.Validation.ValidationModule();

            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();

            //
            // validationModule
            //
            this.validationModule.AllowValidationDetailsAccess = false;
            // 
            // eFlowApiWebApiApplication
            // 
            this.ApplicationName = "eFlowApi";
            this.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema;
            this.Modules.Add(this.module1);
            //this.Modules.Add(this.module2);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.conditionalAppearanceModule);
            this.Modules.Add(this.validationModule);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.eFlowApiWebApiApplication_DatabaseVersionMismatch);

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        //private DevExpress.ExpressApp.WebApi.SystemModule.SystemWebApiModule module2;
        private eFlowApi.Module.eFlowApiModule module3;
        private DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule conditionalAppearanceModule;
        private DevExpress.ExpressApp.Validation.ValidationModule validationModule;
    }
}
