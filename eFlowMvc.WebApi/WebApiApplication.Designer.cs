namespace eFlowMvc.WebApi {
    partial class eFlowMvcWebApiApplication {
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
            this.module3 = new eFlowMvc.Module.eFlowMvcModule();
            this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
            this.cloneObjectModule = new DevExpress.ExpressApp.CloneObject.CloneObjectModule();
            this.conditionalAppearanceModule = new DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule();
            this.validationModule = new DevExpress.ExpressApp.Validation.ValidationModule();

            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();

            //
            // validationModule
            //
            this.validationModule.AllowValidationDetailsAccess = false;
            // 
            // eFlowMvcWebApiApplication
            // 
            this.ApplicationName = "eFlowMvc";
            this.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema;
            this.Modules.Add(this.module1);
            //this.Modules.Add(this.module2);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.securityModule1);
            this.Modules.Add(this.cloneObjectModule);
            this.Modules.Add(this.conditionalAppearanceModule);
            this.Modules.Add(this.validationModule);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.eFlowMvcWebApiApplication_DatabaseVersionMismatch);

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        //private DevExpress.ExpressApp.WebApi.SystemModule.SystemWebApiModule module2;
        private eFlowMvc.Module.eFlowMvcModule module3;
        private DevExpress.ExpressApp.Security.SecurityModule securityModule1;
        private DevExpress.ExpressApp.CloneObject.CloneObjectModule cloneObjectModule;
        private DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule conditionalAppearanceModule;
        private DevExpress.ExpressApp.Validation.ValidationModule validationModule;
    }
}
