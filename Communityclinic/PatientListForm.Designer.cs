namespace CommunityClinic
{
    partial class PatientListForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(
                    typeof(PatientListForm));

            this.communityClinicLLOMDBDataSet =
                new CommunityClinic.CommunityClinicLLOMDBDataSet();

            this.patientBindingSource =
                new System.Windows.Forms.BindingSource(this.components);

            this.patientTableAdapter =
                new CommunityClinic.CommunityClinicLLOMDBDataSetTableAdapters.PatientTableAdapter();

            this.tableAdapterManager =
                new CommunityClinic.CommunityClinicLLOMDBDataSetTableAdapters.TableAdapterManager();

            this.patientBindingNavigator =
                new System.Windows.Forms.BindingNavigator(this.components);

            this.bindingNavigatorAddNewItem =
                new System.Windows.Forms.ToolStripButton();

            this.bindingNavigatorCountItem =
                new System.Windows.Forms.ToolStripLabel();

            this.bindingNavigatorDeleteItem =
                new System.Windows.Forms.ToolStripButton();

            this.bindingNavigatorMoveFirstItem =
                new System.Windows.Forms.ToolStripButton();

            this.bindingNavigatorMovePreviousItem =
                new System.Windows.Forms.ToolStripButton();

            this.bindingNavigatorSeparator =
                new System.Windows.Forms.ToolStripSeparator();

            this.bindingNavigatorPositionItem =
                new System.Windows.Forms.ToolStripTextBox();

            this.bindingNavigatorSeparator1 =
                new System.Windows.Forms.ToolStripSeparator();

            this.bindingNavigatorMoveNextItem =
                new System.Windows.Forms.ToolStripButton();

            this.bindingNavigatorMoveLastItem =
                new System.Windows.Forms.ToolStripButton();

            this.bindingNavigatorSeparator2 =
                new System.Windows.Forms.ToolStripSeparator();

            this.patientBindingNavigatorSaveItem =
                new System.Windows.Forms.ToolStripButton();

            this.patientDataGridView =
                new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.communityClinicLLOMDBDataSet)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.patientBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.patientBindingNavigator)).BeginInit();

            this.patientBindingNavigator.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.patientDataGridView)).BeginInit();

            this.SuspendLayout();

            this.communityClinicLLOMDBDataSet.DataSetName =
                "CommunityClinicLLOMDBDataSet";

            this.communityClinicLLOMDBDataSet.SchemaSerializationMode =

            this.patientBindingSource.DataMember = "Patient";

            this.patientBindingSource.DataSource =

 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;

            this.tableAdapterManager.PatientTableAdapter =
                this.patientTableAdapter;

            this.tableAdapterManager.UpdateOrder =
                CommunityClinic
                .CommunityClinicLLOMDBDataSetTableAdapters
                .TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;

            this.patientBindingNavigator.AddNewItem =
                this.bindingNavigatorAddNewItem;

            this.patientBindingNavigator.BindingSource =
                this.patientBindingSource;

            this.patientBindingNavigator.CountItem =
                this.bindingNavigatorCountItem;

            this.patientBindingNavigator.DeleteItem =
                this.bindingNavigatorDeleteItem;

            this.patientBindingNavigator.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.bindingNavigatorMoveFirstItem,
                    this.bindingNavigatorMovePreviousItem,
                    this.bindingNavigatorSeparator,
                    this.bindingNavigatorPositionItem,
                    this.bindingNavigatorCountItem,
                    this.bindingNavigatorSeparator1,
                    this.bindingNavigatorMoveNextItem,
                    this.bindingNavigatorMoveLastItem,
                    this.bindingNavigatorSeparator2,
                    this.bindingNavigatorAddNewItem,
                    this.bindingNavigatorDeleteItem,
                    this.patientBindingNavigatorSaveItem
                });

            this.patientBindingNavigator.Location =
                new System.Drawing.Point(0, 0);

            this.patientBindingNavigator.MoveFirstItem =
                this.bindingNavigatorMoveFirstItem;

            this.patientBindingNavigator.MoveLastItem =
                this.bindingNavigatorMoveLastItem;

            this.patientBindingNavigator.MoveNextItem =
                this.bindingNavigatorMoveNextItem;

            this.patientBindingNavigator.MovePreviousItem =
                this.bindingNavigatorMovePreviousItem;

            this.patientBindingNavigator.Name =
                "patientBindingNavigator";

            this.patientBindingNavigator.PositionItem =
                this.bindingNavigatorPositionItem;

            this.patientBindingNavigator.Size =
                new System.Drawing.Size(1000, 27);

            this.bindingNavigatorMoveFirstItem.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Image;

            this.bindingNavigatorMoveFirstItem.Image =
                ((System.Drawing.Image)
                (resources.GetObject("bindingNavigatorMoveFirstItem.Image")));

            this.bindingNavigatorMoveFirstItem.Name =
                "bindingNavigatorMoveFirstItem";

            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage =
                true;

            this.bindingNavigatorMoveFirstItem.Text =
                "Move first";

            this.bindingNavigatorMovePreviousItem.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Image;

            this.bindingNavigatorMovePreviousItem.Image =
                ((System.Drawing.Image)
                (resources.GetObject("bindingNavigatorMovePreviousItem.Image")));

            this.bindingNavigatorMovePreviousItem.Name =
                "bindingNavigatorMovePreviousItem";

            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage =
                true;

            this.bindingNavigatorPositionItem.AutoSize = false;

            this.bindingNavigatorPositionItem.Size =
                new System.Drawing.Size(50, 27);

    
            this.bindingNavigatorCountItem.Text = "of {0}";


            this.bindingNavigatorMoveNextItem.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Image;

            this.bindingNavigatorMoveNextItem.Image =
                ((System.Drawing.Image)
                (resources.GetObject("bindingNavigatorMoveNextItem.Image")));

            this.bindingNavigatorMoveLastItem.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Image;

            this.bindingNavigatorMoveLastItem.Image =
                ((System.Drawing.Image)
                (resources.GetObject("bindingNavigatorMoveLastItem.Image")));

            this.bindingNavigatorAddNewItem.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Image;

            this.bindingNavigatorAddNewItem.Image =
                ((System.Drawing.Image)
                (resources.GetObject("bindingNavigatorAddNewItem.Image")));

            this.bindingNavigatorDeleteItem.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Image;

            this.bindingNavigatorDeleteItem.Image =
                ((System.Drawing.Image)
                (resources.GetObject("bindingNavigatorDeleteItem.Image")));

            this.patientBindingNavigatorSaveItem.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Image;

            this.patientBindingNavigatorSaveItem.Image =
                ((System.Drawing.Image)
                (resources.GetObject("patientBindingNavigatorSaveItem.Image")));

            this.patientBindingNavigatorSaveItem.Click +=
                new System.EventHandler(
                    this.patientBindingNavigatorSaveItem_Click);

            this.patientDataGridView.AutoGenerateColumns = true;

            this.patientDataGridView.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode
                .AutoSize;

            this.patientDataGridView.DataSource =
                this.patientBindingSource;

            this.patientDataGridView.Location =
                new System.Drawing.Point(12, 40);

            this.patientDataGridView.Name =
                "patientDataGridView";

            this.patientDataGridView.RowHeadersWidth = 51;

            this.patientDataGridView.Size =
                new System.Drawing.Size(960, 370);

   
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(8F, 16F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1000, 450);

            this.Controls.Add(this.patientDataGridView);

            this.Controls.Add(this.patientBindingNavigator);

            this.Name = "PatientListForm";

            this.Text = "Patient List";

            this.Load +=
                new System.EventHandler(
                    this.PatientListForm_Load);

            ((System.ComponentModel.ISupportInitialize)
                (this.communityClinicLLOMDBDataSet)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.patientBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.patientBindingNavigator)).EndInit();

            this.patientBindingNavigator.ResumeLayout(false);

            this.patientBindingNavigator.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.patientDataGridView)).EndInit();

            this.ResumeLayout(false);

            this.PerformLayout();
        }

        #endregion

        private CommunityClinicLLOMDBDataSet
            communityClinicLLOMDBDataSet;

        private System.Windows.Forms.BindingSource
            patientBindingSource;

        private CommunityClinicLLOMDBDataSetTableAdapters.PatientTableAdapter
            patientTableAdapter;

        private CommunityClinicLLOMDBDataSetTableAdapters.TableAdapterManager
            tableAdapterManager;

        private System.Windows.Forms.BindingNavigator
            patientBindingNavigator;

        private System.Windows.Forms.ToolStripButton
            bindingNavigatorAddNewItem;

        private System.Windows.Forms.ToolStripLabel
            bindingNavigatorCountItem;

        private System.Windows.Forms.ToolStripButton
            bindingNavigatorDeleteItem;

        private System.Windows.Forms.ToolStripButton
            bindingNavigatorMoveFirstItem;

        private System.Windows.Forms.ToolStripButton
            bindingNavigatorMovePreviousItem;

        private System.Windows.Forms.ToolStripSeparator
            bindingNavigatorSeparator;

        private System.Windows.Forms.ToolStripTextBox
            bindingNavigatorPositionItem;

        private System.Windows.Forms.ToolStripSeparator
            bindingNavigatorSeparator1;

        private System.Windows.Forms.ToolStripButton
            bindingNavigatorMoveNextItem;

        private System.Windows.Forms.ToolStripButton
            bindingNavigatorMoveLastItem;

        private System.Windows.Forms.ToolStripSeparator
            bindingNavigatorSeparator2;

        private System.Windows.Forms.ToolStripButton
            patientBindingNavigatorSaveItem;

        private System.Windows.Forms.DataGridView
            patientDataGridView;
    }
}