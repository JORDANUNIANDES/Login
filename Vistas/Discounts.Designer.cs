namespace Login.Vistas
{
    partial class Discounts
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.DataGridView dgvDiscounts;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnEditar;
    private System.Windows.Forms.Button btnEliminar;

    private void InitializeComponent()
    {
        this.dgvDiscounts = new System.Windows.Forms.DataGridView();
        this.btnAgregar = new System.Windows.Forms.Button();
        this.btnEditar = new System.Windows.Forms.Button();
        this.btnEliminar = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).BeginInit();
        this.SuspendLayout();
        // 
        // dgvDiscounts
        // 
        this.dgvDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top |
                                System.Windows.Forms.AnchorStyles.Bottom) |
                                System.Windows.Forms.AnchorStyles.Left) |
                                System.Windows.Forms.AnchorStyles.Right)));
        this.dgvDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvDiscounts.Location = new System.Drawing.Point(12, 12);
        this.dgvDiscounts.Name = "dgvDiscounts";
        this.dgvDiscounts.Size = new System.Drawing.Size(760, 400);
        this.dgvDiscounts.TabIndex = 0;
        // 
        // btnAgregar
        // 
        this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
        this.btnAgregar.Location = new System.Drawing.Point(12, 420);
        this.btnAgregar.Name = "btnAgregar";
        this.btnAgregar.Size = new System.Drawing.Size(75, 23);
        this.btnAgregar.TabIndex = 1;
        this.btnAgregar.Text = "Agregar";
        this.btnAgregar.UseVisualStyleBackColor = true;
        // 
        // btnEditar
        // 
        this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        this.btnEditar.Location = new System.Drawing.Point(350, 420);
        this.btnEditar.Name = "btnEditar";
        this.btnEditar.Size = new System.Drawing.Size(75, 23);
        this.btnEditar.TabIndex = 2;
        this.btnEditar.Text = "Editar";
        this.btnEditar.UseVisualStyleBackColor = true;
        // 
        // btnEliminar
        // 
        this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.btnEliminar.Location = new System.Drawing.Point(697, 420);
        this.btnEliminar.Name = "btnEliminar";
        this.btnEliminar.Size = new System.Drawing.Size(75, 23);
        this.btnEliminar.TabIndex = 3;
        this.btnEliminar.Text = "Eliminar";
        this.btnEliminar.UseVisualStyleBackColor = true;
        // 
        // Discounts
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(784, 461);
        this.Controls.Add(this.btnEliminar);
        this.Controls.Add(this.btnEditar);
        this.Controls.Add(this.btnAgregar);
        this.Controls.Add(this.dgvDiscounts);
        this.Name = "Discounts";
        this.Text = "Discounts";
        ((System.ComponentModel.ISupportInitialize)(this.dgvDiscounts)).EndInit();
        this.ResumeLayout(false);
    }
}