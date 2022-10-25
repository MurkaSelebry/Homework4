namespace Work2410
{
    partial class Parent2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listProducts = new System.Windows.Forms.ListBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProducts
            // 
            this.listProducts.FormattingEnabled = true;
            this.listProducts.Location = new System.Drawing.Point(0, 0);
            this.listProducts.Margin = new System.Windows.Forms.Padding(0);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(260, 316);
            this.listProducts.TabIndex = 0;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(0, 316);
            this.bt_add.Margin = new System.Windows.Forms.Padding(0);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(260, 30);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Добавить товар";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(0, 376);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(0);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(260, 30);
            this.bt_delete.TabIndex = 3;
            this.bt_delete.Text = "Удалить товар";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(0, 406);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(0);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(260, 30);
            this.bt_clear.TabIndex = 4;
            this.bt_clear.Text = "Очистить список";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(0, 346);
            this.bt_edit.Margin = new System.Windows.Forms.Padding(0);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(260, 30);
            this.bt_edit.TabIndex = 2;
            this.bt_edit.Text = "Редактировать товар";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // Parent2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 436);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.listProducts);
            this.Name = "Parent2";
            this.Text = "Parent2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listProducts;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_edit;
    }
}