namespace FolderCrawling
{
    partial class GUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonChooseDirectory = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextTes = new System.Windows.Forms.RichTextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textFolderCrawling = new System.Windows.Forms.TextBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.textChooseDirectoryHeader = new System.Windows.Forms.TextBox();
            this.textInputFileHeader = new System.Windows.Forms.TextBox();
            this.textInputFile = new System.Windows.Forms.TextBox();
            this.textInputSearchingMethodHeader = new System.Windows.Forms.TextBox();
            this.buttonBFS = new System.Windows.Forms.RadioButton();
            this.buttonDFS = new System.Windows.Forms.RadioButton();
            this.checkBoxFindAll = new System.Windows.Forms.CheckBox();
            this.textFileDirectory = new System.Windows.Forms.RichTextBox();
            this.graphContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.textFilePathHeader = new System.Windows.Forms.TextBox();
            this.textFilePath = new System.Windows.Forms.RichTextBox();
            this.textFolderRouteHeader = new System.Windows.Forms.TextBox();
            this.textFolderRoute = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonChooseDirectory
            // 
            this.buttonChooseDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.buttonChooseDirectory.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonChooseDirectory.FlatAppearance.BorderSize = 2;
            this.buttonChooseDirectory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.buttonChooseDirectory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.buttonChooseDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChooseDirectory.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChooseDirectory.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonChooseDirectory.Location = new System.Drawing.Point(140, 247);
            this.buttonChooseDirectory.Name = "buttonChooseDirectory";
            this.buttonChooseDirectory.Size = new System.Drawing.Size(235, 46);
            this.buttonChooseDirectory.TabIndex = 2;
            this.buttonChooseDirectory.Text = "Choose Folder...";
            this.buttonChooseDirectory.UseVisualStyleBackColor = false;
            this.buttonChooseDirectory.Click += new System.EventHandler(this.buttonChooseDirectory_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(611, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(121, 40);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Output";
            // 
            // richTextTes
            // 
            this.richTextTes.Location = new System.Drawing.Point(100, 765);
            this.richTextTes.Name = "richTextTes";
            this.richTextTes.Size = new System.Drawing.Size(416, 123);
            this.richTextTes.TabIndex = 13;
            this.richTextTes.Text = "";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Berlin Sans FB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSearch.Location = new System.Drawing.Point(140, 709);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(329, 50);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textFolderCrawling
            // 
            this.textFolderCrawling.BackColor = System.Drawing.SystemColors.Window;
            this.textFolderCrawling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFolderCrawling.Font = new System.Drawing.Font("Berlin Sans FB", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textFolderCrawling.Location = new System.Drawing.Point(748, 50);
            this.textFolderCrawling.Name = "textFolderCrawling";
            this.textFolderCrawling.ReadOnly = true;
            this.textFolderCrawling.Size = new System.Drawing.Size(404, 49);
            this.textFolderCrawling.TabIndex = 15;
            this.textFolderCrawling.Text = "FOLDER CRAWLING";
            this.textFolderCrawling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textInput
            // 
            this.textInput.BackColor = System.Drawing.SystemColors.Window;
            this.textInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInput.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textInput.Location = new System.Drawing.Point(140, 120);
            this.textInput.Name = "textInput";
            this.textInput.ReadOnly = true;
            this.textInput.Size = new System.Drawing.Size(80, 40);
            this.textInput.TabIndex = 16;
            this.textInput.Text = "Input";
            // 
            // textChooseDirectoryHeader
            // 
            this.textChooseDirectoryHeader.BackColor = System.Drawing.SystemColors.Window;
            this.textChooseDirectoryHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textChooseDirectoryHeader.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textChooseDirectoryHeader.Location = new System.Drawing.Point(140, 199);
            this.textChooseDirectoryHeader.Name = "textChooseDirectoryHeader";
            this.textChooseDirectoryHeader.ReadOnly = true;
            this.textChooseDirectoryHeader.Size = new System.Drawing.Size(277, 27);
            this.textChooseDirectoryHeader.TabIndex = 17;
            this.textChooseDirectoryHeader.Text = "Choose Starting Directory";
            // 
            // textInputFileHeader
            // 
            this.textInputFileHeader.BackColor = System.Drawing.SystemColors.Window;
            this.textInputFileHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInputFileHeader.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textInputFileHeader.Location = new System.Drawing.Point(140, 374);
            this.textInputFileHeader.Name = "textInputFileHeader";
            this.textInputFileHeader.ReadOnly = true;
            this.textInputFileHeader.Size = new System.Drawing.Size(277, 27);
            this.textInputFileHeader.TabIndex = 19;
            this.textInputFileHeader.Text = "Input File Name";
            // 
            // textInputFile
            // 
            this.textInputFile.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textInputFile.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textInputFile.Location = new System.Drawing.Point(140, 422);
            this.textInputFile.Name = "textInputFile";
            this.textInputFile.Size = new System.Drawing.Size(329, 27);
            this.textInputFile.TabIndex = 20;
            this.textInputFile.Text = "e.g. word.pdf";
            // 
            // textInputSearchingMethodHeader
            // 
            this.textInputSearchingMethodHeader.BackColor = System.Drawing.SystemColors.Window;
            this.textInputSearchingMethodHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInputSearchingMethodHeader.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textInputSearchingMethodHeader.Location = new System.Drawing.Point(140, 562);
            this.textInputSearchingMethodHeader.Name = "textInputSearchingMethodHeader";
            this.textInputSearchingMethodHeader.ReadOnly = true;
            this.textInputSearchingMethodHeader.Size = new System.Drawing.Size(277, 27);
            this.textInputSearchingMethodHeader.TabIndex = 21;
            this.textInputSearchingMethodHeader.Text = "Input Metode Pencarian";
            // 
            // buttonBFS
            // 
            this.buttonBFS.AutoSize = true;
            this.buttonBFS.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonBFS.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBFS.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonBFS.Location = new System.Drawing.Point(140, 608);
            this.buttonBFS.Name = "buttonBFS";
            this.buttonBFS.Size = new System.Drawing.Size(67, 27);
            this.buttonBFS.TabIndex = 22;
            this.buttonBFS.TabStop = true;
            this.buttonBFS.Text = "BFS";
            this.buttonBFS.UseVisualStyleBackColor = true;
            // 
            // buttonDFS
            // 
            this.buttonDFS.AutoSize = true;
            this.buttonDFS.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDFS.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDFS.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonDFS.Location = new System.Drawing.Point(140, 641);
            this.buttonDFS.Name = "buttonDFS";
            this.buttonDFS.Size = new System.Drawing.Size(69, 27);
            this.buttonDFS.TabIndex = 23;
            this.buttonDFS.TabStop = true;
            this.buttonDFS.Text = "DFS";
            this.buttonDFS.UseVisualStyleBackColor = true;
            // 
            // checkBoxFindAll
            // 
            this.checkBoxFindAll.AutoSize = true;
            this.checkBoxFindAll.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFindAll.ForeColor = System.Drawing.Color.Black;
            this.checkBoxFindAll.Location = new System.Drawing.Point(140, 483);
            this.checkBoxFindAll.Name = "checkBoxFindAll";
            this.checkBoxFindAll.Size = new System.Drawing.Size(175, 24);
            this.checkBoxFindAll.TabIndex = 24;
            this.checkBoxFindAll.Text = "Find All Occurence";
            this.checkBoxFindAll.UseVisualStyleBackColor = true;
            // 
            // textFileDirectory
            // 
            this.textFileDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.textFileDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFileDirectory.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textFileDirectory.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textFileDirectory.Location = new System.Drawing.Point(140, 306);
            this.textFileDirectory.Name = "textFileDirectory";
            this.textFileDirectory.ReadOnly = true;
            this.textFileDirectory.Size = new System.Drawing.Size(289, 62);
            this.textFileDirectory.TabIndex = 25;
            this.textFileDirectory.Text = "No file chosen";
            // 
            // graphContainer
            // 
            this.graphContainer.Location = new System.Drawing.Point(611, 175);
            this.graphContainer.Name = "graphContainer";
            this.graphContainer.Size = new System.Drawing.Size(1223, 493);
            this.graphContainer.TabIndex = 27;
            // 
            // textFilePathHeader
            // 
            this.textFilePathHeader.BackColor = System.Drawing.SystemColors.Window;
            this.textFilePathHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFilePathHeader.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textFilePathHeader.Location = new System.Drawing.Point(611, 760);
            this.textFilePathHeader.Name = "textFilePathHeader";
            this.textFilePathHeader.ReadOnly = true;
            this.textFilePathHeader.Size = new System.Drawing.Size(121, 27);
            this.textFilePathHeader.TabIndex = 30;
            this.textFilePathHeader.Text = "File Path";
            // 
            // textFilePath
            // 
            this.textFilePath.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textFilePath.Location = new System.Drawing.Point(611, 804);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(1221, 108);
            this.textFilePath.TabIndex = 31;
            this.textFilePath.Text = "";
            // 
            // textFolderRouteHeader
            // 
            this.textFolderRouteHeader.BackColor = System.Drawing.SystemColors.Window;
            this.textFolderRouteHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFolderRouteHeader.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textFolderRouteHeader.Location = new System.Drawing.Point(611, 706);
            this.textFolderRouteHeader.Name = "textFolderRouteHeader";
            this.textFolderRouteHeader.ReadOnly = true;
            this.textFolderRouteHeader.Size = new System.Drawing.Size(150, 27);
            this.textFolderRouteHeader.TabIndex = 32;
            this.textFolderRouteHeader.Text = "Folder Route";
            // 
            // textFolderRoute
            // 
            this.textFolderRoute.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textFolderRoute.Location = new System.Drawing.Point(758, 701);
            this.textFolderRoute.Name = "textFolderRoute";
            this.textFolderRoute.Size = new System.Drawing.Size(1076, 45);
            this.textFolderRoute.TabIndex = 33;
            this.textFolderRoute.Text = "";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(552, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 850);
            this.label2.TabIndex = 35;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1386, 915);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFolderRoute);
            this.Controls.Add(this.textFolderRouteHeader);
            this.Controls.Add(this.textFilePath);
            this.Controls.Add(this.textFilePathHeader);
            this.Controls.Add(this.graphContainer);
            this.Controls.Add(this.textFileDirectory);
            this.Controls.Add(this.checkBoxFindAll);
            this.Controls.Add(this.buttonDFS);
            this.Controls.Add(this.buttonBFS);
            this.Controls.Add(this.textInputSearchingMethodHeader);
            this.Controls.Add(this.textInputFile);
            this.Controls.Add(this.textInputFileHeader);
            this.Controls.Add(this.textChooseDirectoryHeader);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.textFolderCrawling);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.richTextTes);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonChooseDirectory);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "GUI";
            this.Text = "Folder Crawling";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Button buttonChooseDirectory;
        private TextBox textBox2;
        private RichTextBox richTextTes;
        private Button buttonSearch;
        private TextBox textFolderCrawling;
        private TextBox textInput;
        private TextBox textChooseDirectoryHeader;
        private TextBox textInputFileHeader;
        private TextBox textInputFile;
        private TextBox textInputSearchingMethodHeader;
        private RadioButton buttonBFS;
        private RadioButton buttonDFS;
        private CheckBox checkBoxFindAll;
        private RichTextBox textFileDirectory;
        private FlowLayoutPanel graphContainer;
        private TextBox textFilePathHeader;
        private RichTextBox textFilePath;
        private TextBox textFolderRouteHeader;
        private RichTextBox textFolderRoute;
        private Label label2;
    }
}