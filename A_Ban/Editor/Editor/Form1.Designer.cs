namespace Editor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새파일NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.지우기EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잘라내기TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.폰트변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(746, 392);
            this.textBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새파일NToolStripMenuItem,
            this.열기OToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.다른이름저장ToolStripMenuItem,
            this.지우기EToolStripMenuItem,
            this.toolStripMenuItem1,
            this.종료XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 새파일NToolStripMenuItem
            // 
            this.새파일NToolStripMenuItem.Name = "새파일NToolStripMenuItem";
            this.새파일NToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.새파일NToolStripMenuItem.Text = "새 파일(&N)";
            this.새파일NToolStripMenuItem.Click += new System.EventHandler(this.새파일NToolStripMenuItem_Click);
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.열기OToolStripMenuItem.Text = "열기(&O)";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.저장SToolStripMenuItem.Text = "저장(&S)";
            this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
            // 
            // 다른이름저장ToolStripMenuItem
            // 
            this.다른이름저장ToolStripMenuItem.Name = "다른이름저장ToolStripMenuItem";
            this.다른이름저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.다른이름저장ToolStripMenuItem.Text = "다른 이름 저장";
            this.다른이름저장ToolStripMenuItem.Click += new System.EventHandler(this.다른이름저장ToolStripMenuItem_Click);
            // 
            // 지우기EToolStripMenuItem
            // 
            this.지우기EToolStripMenuItem.Name = "지우기EToolStripMenuItem";
            this.지우기EToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.지우기EToolStripMenuItem.Text = "지우기(&E)";
            this.지우기EToolStripMenuItem.Click += new System.EventHandler(this.지우기EToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.종료XToolStripMenuItem.Text = "종료(&X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.복사CToolStripMenuItem,
            this.붙여넣기VToolStripMenuItem,
            this.잘라내기TToolStripMenuItem,
            this.toolStripMenuItem2,
            this.폰트변경ToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집EToolStripMenuItem.Text = "편집(&E)";
            // 
            // 복사CToolStripMenuItem
            // 
            this.복사CToolStripMenuItem.Name = "복사CToolStripMenuItem";
            this.복사CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.복사CToolStripMenuItem.Text = "복사(&C)";
            this.복사CToolStripMenuItem.Click += new System.EventHandler(this.복사CToolStripMenuItem_Click);
            // 
            // 붙여넣기VToolStripMenuItem
            // 
            this.붙여넣기VToolStripMenuItem.Name = "붙여넣기VToolStripMenuItem";
            this.붙여넣기VToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.붙여넣기VToolStripMenuItem.Text = "붙여넣기(&V)";
            this.붙여넣기VToolStripMenuItem.Click += new System.EventHandler(this.붙여넣기VToolStripMenuItem_Click);
            // 
            // 잘라내기TToolStripMenuItem
            // 
            this.잘라내기TToolStripMenuItem.Name = "잘라내기TToolStripMenuItem";
            this.잘라내기TToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.잘라내기TToolStripMenuItem.Text = "잘라내기(&T)";
            this.잘라내기TToolStripMenuItem.Click += new System.EventHandler(this.잘라내기TToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // 폰트변경ToolStripMenuItem
            // 
            this.폰트변경ToolStripMenuItem.Name = "폰트변경ToolStripMenuItem";
            this.폰트변경ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.폰트변경ToolStripMenuItem.Text = "폰트 변경";
            this.폰트변경ToolStripMenuItem.Click += new System.EventHandler(this.폰트변경ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새파일NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 지우기EToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 폰트변경ToolStripMenuItem;
    }
}

