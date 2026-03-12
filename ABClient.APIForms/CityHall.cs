using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ABClient.APIForms;

public class CityHall : Form
{
	private sealed class Class108
	{
		public string string_0;

		public string string_1;

		public Class108(string string_2)
		{
			string[] array = string_2.Split('|');
			string_1 = array[2];
			string_0 = "http://image.neverlands.ru/weapon/" + array[3];
		}
	}

	private IContainer icontainer_0;

	private Button ForpostButton;

	private Button OktalButton;

	private Label ItemsLabel;

	private PictureBox PictureBox;

	private Label ProductLabel;

	public CityHall()
	{
		InitializeComponent();
	}

	private void ForpostButton_Click(object sender, EventArgs e)
	{
		method_0(1);
	}

	private void OktalButton_Click(object sender, EventArgs e)
	{
		method_0(2);
	}

	private void method_0(int int_0)
	{
		string[] array = Class21.smethod_5(int_0).Split('\n');
		string[] array2 = array[0].Split('|');
		string text = array2[1];
		string text2 = array2[2];
		string[] array3 = array[1].Replace("order|", string.Empty).Split('@');
		Class108 @class = new Class108(array[2]);
		string newLine = Environment.NewLine;
		PictureBox.ImageLocation = @class.string_0;
		ProductLabel.Text = @class.string_1;
		ItemsLabel.Text = "Заказ активен" + newLine + " с " + text + newLine + "по " + text2 + newLine + newLine;
		string[] array4 = array3;
		foreach (string text3 in array4)
		{
			if (!string.IsNullOrEmpty(text3))
			{
				string[] array5 = text3.Split(',');
				Label itemsLabel = ItemsLabel;
				itemsLabel.Text = itemsLabel.Text + array5[2] + " [ " + array5[4] + " / " + array5[5] + " ]" + newLine;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABClient.APIForms.CityHall));
		this.ForpostButton = new System.Windows.Forms.Button();
		this.OktalButton = new System.Windows.Forms.Button();
		this.ItemsLabel = new System.Windows.Forms.Label();
		this.PictureBox = new System.Windows.Forms.PictureBox();
		this.ProductLabel = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.PictureBox).BeginInit();
		base.SuspendLayout();
		this.ForpostButton.Location = new System.Drawing.Point(150, 12);
		this.ForpostButton.Name = "ForpostButton";
		this.ForpostButton.Size = new System.Drawing.Size(75, 23);
		this.ForpostButton.TabIndex = 0;
		this.ForpostButton.Text = "Форпост";
		this.ForpostButton.UseVisualStyleBackColor = true;
		this.ForpostButton.Click += new System.EventHandler(ForpostButton_Click);
		this.OktalButton.Location = new System.Drawing.Point(231, 12);
		this.OktalButton.Name = "OktalButton";
		this.OktalButton.Size = new System.Drawing.Size(75, 23);
		this.OktalButton.TabIndex = 1;
		this.OktalButton.Text = "Октал";
		this.OktalButton.UseVisualStyleBackColor = true;
		this.OktalButton.Click += new System.EventHandler(OktalButton_Click);
		this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.ItemsLabel.Location = new System.Drawing.Point(12, 52);
		this.ItemsLabel.Name = "ItemsLabel";
		this.ItemsLabel.Size = new System.Drawing.Size(433, 421);
		this.ItemsLabel.TabIndex = 2;
		this.ItemsLabel.Text = "Информация о заказе";
		this.ItemsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.PictureBox.Location = new System.Drawing.Point(16, 508);
		this.PictureBox.Name = "PictureBox";
		this.PictureBox.Size = new System.Drawing.Size(100, 150);
		this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.PictureBox.TabIndex = 3;
		this.PictureBox.TabStop = false;
		this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.ProductLabel.Location = new System.Drawing.Point(16, 473);
		this.ProductLabel.Name = "ProductLabel";
		this.ProductLabel.Size = new System.Drawing.Size(429, 32);
		this.ProductLabel.TabIndex = 4;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(459, 661);
		base.Controls.Add(this.ProductLabel);
		base.Controls.Add(this.PictureBox);
		base.Controls.Add(this.ItemsLabel);
		base.Controls.Add(this.OktalButton);
		base.Controls.Add(this.ForpostButton);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		this.MaximumSize = new System.Drawing.Size(475, 700);
		base.MinimizeBox = false;
		this.MinimumSize = new System.Drawing.Size(475, 700);
		base.Name = "CityHall";
		this.Text = "Ратуша";
		((System.ComponentModel.ISupportInitialize)this.PictureBox).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
