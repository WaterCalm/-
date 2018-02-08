<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_KuyunEYELink = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_CSMLink = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox_C1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_C3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_C2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_C1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView_Data = New System.Windows.Forms.DataGridView()
        Me.序号 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.时间 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label_Time = New System.Windows.Forms.Label()
        Me.Button_Start = New System.Windows.Forms.Button()
        Me.Button_Stop = New System.Windows.Forms.Button()
        Me.Button_OpenFile = New System.Windows.Forms.Button()
        Me.Button_SaveAs = New System.Windows.Forms.Button()
        Me.Label_SaveAs = New System.Windows.Forms.Label()
        Me.Label_SavePath = New System.Windows.Forms.Label()
        Me.TextBox_Cookie_quanguo = New System.Windows.Forms.TextBox()
        Me.TextBox_Cookie_52 = New System.Windows.Forms.TextBox()
        Me.TextBox_Cookie_35 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer_SysTime = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Timer_CreateRow = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label_kuyun_state = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label_CSMALL = New System.Windows.Forms.Label()
        Me.Label_CSM52 = New System.Windows.Forms.Label()
        Me.Label_CSM35 = New System.Windows.Forms.Label()
        Me.GroupBox_C1.SuspendLayout()
        CType(Me.DataGridView_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "酷云EYE："
        '
        'TextBox_KuyunEYELink
        '
        Me.TextBox_KuyunEYELink.Location = New System.Drawing.Point(86, 77)
        Me.TextBox_KuyunEYELink.Name = "TextBox_KuyunEYELink"
        Me.TextBox_KuyunEYELink.Size = New System.Drawing.Size(486, 21)
        Me.TextBox_KuyunEYELink.TabIndex = 1
        Me.TextBox_KuyunEYELink.Text = "http://eye.kuyun.com/api/sec_ratings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CSM-Huan："
        '
        'TextBox_CSMLink
        '
        Me.TextBox_CSMLink.Location = New System.Drawing.Point(86, 104)
        Me.TextBox_CSMLink.Name = "TextBox_CSMLink"
        Me.TextBox_CSMLink.Size = New System.Drawing.Size(486, 21)
        Me.TextBox_CSMLink.TabIndex = 3
        Me.TextBox_CSMLink.Text = "http://www.csm-huan.com/history_compare"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "数据来源："
        '
        'GroupBox_C1
        '
        Me.GroupBox_C1.Controls.Add(Me.Label10)
        Me.GroupBox_C1.Controls.Add(Me.Label9)
        Me.GroupBox_C1.Controls.Add(Me.Label8)
        Me.GroupBox_C1.Controls.Add(Me.Label_CSM35)
        Me.GroupBox_C1.Controls.Add(Me.Label_CSM52)
        Me.GroupBox_C1.Controls.Add(Me.Label_CSMALL)
        Me.GroupBox_C1.Controls.Add(Me.Label_kuyun_state)
        Me.GroupBox_C1.Controls.Add(Me.Label7)
        Me.GroupBox_C1.Controls.Add(Me.CheckBox_C3)
        Me.GroupBox_C1.Controls.Add(Me.CheckBox_C2)
        Me.GroupBox_C1.Controls.Add(Me.CheckBox_C1)
        Me.GroupBox_C1.Controls.Add(Me.ComboBox3)
        Me.GroupBox_C1.Controls.Add(Me.ComboBox2)
        Me.GroupBox_C1.Controls.Add(Me.ComboBox1)
        Me.GroupBox_C1.Location = New System.Drawing.Point(23, 214)
        Me.GroupBox_C1.Name = "GroupBox_C1"
        Me.GroupBox_C1.Size = New System.Drawing.Size(549, 111)
        Me.GroupBox_C1.TabIndex = 7
        Me.GroupBox_C1.TabStop = False
        Me.GroupBox_C1.Text = "频道选择"
        '
        'CheckBox_C3
        '
        Me.CheckBox_C3.AutoSize = True
        Me.CheckBox_C3.Enabled = False
        Me.CheckBox_C3.Location = New System.Drawing.Point(417, 25)
        Me.CheckBox_C3.Name = "CheckBox_C3"
        Me.CheckBox_C3.Size = New System.Drawing.Size(60, 16)
        Me.CheckBox_C3.TabIndex = 7
        Me.CheckBox_C3.Text = "频道三"
        Me.CheckBox_C3.UseVisualStyleBackColor = True
        '
        'CheckBox_C2
        '
        Me.CheckBox_C2.AutoSize = True
        Me.CheckBox_C2.Enabled = False
        Me.CheckBox_C2.Location = New System.Drawing.Point(235, 25)
        Me.CheckBox_C2.Name = "CheckBox_C2"
        Me.CheckBox_C2.Size = New System.Drawing.Size(60, 16)
        Me.CheckBox_C2.TabIndex = 6
        Me.CheckBox_C2.Text = "频道二"
        Me.CheckBox_C2.UseVisualStyleBackColor = True
        '
        'CheckBox_C1
        '
        Me.CheckBox_C1.AutoSize = True
        Me.CheckBox_C1.Checked = True
        Me.CheckBox_C1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_C1.Enabled = False
        Me.CheckBox_C1.Location = New System.Drawing.Point(53, 25)
        Me.CheckBox_C1.Name = "CheckBox_C1"
        Me.CheckBox_C1.Size = New System.Drawing.Size(60, 16)
        Me.CheckBox_C1.TabIndex = 5
        Me.CheckBox_C1.Text = "频道一"
        Me.CheckBox_C1.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(392, 47)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox3.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(209, 47)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(26, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 0
        '
        'DataGridView_Data
        '
        Me.DataGridView_Data.AllowUserToAddRows = False
        Me.DataGridView_Data.AllowUserToDeleteRows = False
        Me.DataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.序号, Me.时间})
        Me.DataGridView_Data.Location = New System.Drawing.Point(23, 447)
        Me.DataGridView_Data.Name = "DataGridView_Data"
        Me.DataGridView_Data.ReadOnly = True
        Me.DataGridView_Data.RowTemplate.Height = 23
        Me.DataGridView_Data.Size = New System.Drawing.Size(549, 150)
        Me.DataGridView_Data.TabIndex = 6
        '
        '序号
        '
        Me.序号.HeaderText = "序号"
        Me.序号.Name = "序号"
        Me.序号.ReadOnly = True
        Me.序号.Width = 60
        '
        '时间
        '
        Me.时间.HeaderText = "时间"
        Me.时间.Name = "时间"
        Me.时间.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label_Time)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 341)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "时间"
        '
        'Label_Time
        '
        Me.Label_Time.AutoSize = True
        Me.Label_Time.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Time.ForeColor = System.Drawing.Color.Green
        Me.Label_Time.Location = New System.Drawing.Point(43, 25)
        Me.Label_Time.Name = "Label_Time"
        Me.Label_Time.Size = New System.Drawing.Size(230, 60)
        Me.Label_Time.TabIndex = 0
        Me.Label_Time.Text = "23 : 59 : 59"
        '
        'Button_Start
        '
        Me.Button_Start.Location = New System.Drawing.Point(370, 354)
        Me.Button_Start.Name = "Button_Start"
        Me.Button_Start.Size = New System.Drawing.Size(75, 36)
        Me.Button_Start.TabIndex = 9
        Me.Button_Start.Text = "开始检测"
        Me.Button_Start.UseVisualStyleBackColor = True
        '
        'Button_Stop
        '
        Me.Button_Stop.Enabled = False
        Me.Button_Stop.Location = New System.Drawing.Point(370, 396)
        Me.Button_Stop.Name = "Button_Stop"
        Me.Button_Stop.Size = New System.Drawing.Size(75, 36)
        Me.Button_Stop.TabIndex = 10
        Me.Button_Stop.Text = "停止监测"
        Me.Button_Stop.UseVisualStyleBackColor = True
        '
        'Button_OpenFile
        '
        Me.Button_OpenFile.Location = New System.Drawing.Point(451, 354)
        Me.Button_OpenFile.Name = "Button_OpenFile"
        Me.Button_OpenFile.Size = New System.Drawing.Size(75, 36)
        Me.Button_OpenFile.TabIndex = 11
        Me.Button_OpenFile.Text = "打开文件夹"
        Me.Button_OpenFile.UseVisualStyleBackColor = True
        '
        'Button_SaveAs
        '
        Me.Button_SaveAs.Location = New System.Drawing.Point(451, 396)
        Me.Button_SaveAs.Name = "Button_SaveAs"
        Me.Button_SaveAs.Size = New System.Drawing.Size(75, 36)
        Me.Button_SaveAs.TabIndex = 12
        Me.Button_SaveAs.Text = "文件另存"
        Me.Button_SaveAs.UseVisualStyleBackColor = True
        '
        'Label_SaveAs
        '
        Me.Label_SaveAs.AutoSize = True
        Me.Label_SaveAs.Location = New System.Drawing.Point(21, 608)
        Me.Label_SaveAs.Name = "Label_SaveAs"
        Me.Label_SaveAs.Size = New System.Drawing.Size(29, 12)
        Me.Label_SaveAs.TabIndex = 13
        Me.Label_SaveAs.Text = "空白"
        '
        'Label_SavePath
        '
        Me.Label_SavePath.AutoSize = True
        Me.Label_SavePath.Location = New System.Drawing.Point(114, 608)
        Me.Label_SavePath.Name = "Label_SavePath"
        Me.Label_SavePath.Size = New System.Drawing.Size(41, 12)
        Me.Label_SavePath.TabIndex = 14
        Me.Label_SavePath.Text = "路径："
        '
        'TextBox_Cookie_quanguo
        '
        Me.TextBox_Cookie_quanguo.Location = New System.Drawing.Point(86, 131)
        Me.TextBox_Cookie_quanguo.Name = "TextBox_Cookie_quanguo"
        Me.TextBox_Cookie_quanguo.Size = New System.Drawing.Size(486, 21)
        Me.TextBox_Cookie_quanguo.TabIndex = 15
        Me.TextBox_Cookie_quanguo.Text = "flag=hour&queryType=all"
        '
        'TextBox_Cookie_52
        '
        Me.TextBox_Cookie_52.Location = New System.Drawing.Point(86, 159)
        Me.TextBox_Cookie_52.Name = "TextBox_Cookie_52"
        Me.TextBox_Cookie_52.Size = New System.Drawing.Size(486, 21)
        Me.TextBox_Cookie_52.TabIndex = 16
        Me.TextBox_Cookie_52.Text = "flag=hour&queryType=city52"
        '
        'TextBox_Cookie_35
        '
        Me.TextBox_Cookie_35.Location = New System.Drawing.Point(86, 187)
        Me.TextBox_Cookie_35.Name = "TextBox_Cookie_35"
        Me.TextBox_Cookie_35.Size = New System.Drawing.Size(486, 21)
        Me.TextBox_Cookie_35.TabIndex = 17
        Me.TextBox_Cookie_35.Text = "flag=hour&queryType=city35"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "全国网："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "52城："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "35城："
        '
        'Timer_SysTime
        '
        Me.Timer_SysTime.Enabled = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(629, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(741, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(629, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 21)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Text = "http://eye.kuyun.com/api/sec_ratings?tv_id=5"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(629, 112)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(570, 201)
        Me.TextBox2.TabIndex = 24
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.收视率实时监测.My.Resources.Resources.csmhuanlogo
        Me.PictureBox2.Location = New System.Drawing.Point(268, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(258, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.收视率实时监测.My.Resources.Resources.酷云logo
        Me.PictureBox1.Location = New System.Drawing.Point(130, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(629, 80)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(276, 21)
        Me.TextBox3.TabIndex = 25
        Me.TextBox3.Text = "channel_codes=cctv1&flag=hour&queryType=all"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(629, 319)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 12)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "酷云EYE"
        '
        'Label_kuyun_state
        '
        Me.Label_kuyun_state.AutoSize = True
        Me.Label_kuyun_state.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_kuyun_state.ForeColor = System.Drawing.Color.Green
        Me.Label_kuyun_state.Location = New System.Drawing.Point(69, 87)
        Me.Label_kuyun_state.Name = "Label_kuyun_state"
        Me.Label_kuyun_state.Size = New System.Drawing.Size(18, 12)
        Me.Label_kuyun_state.TabIndex = 9
        Me.Label_kuyun_state.Text = "√"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(107, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "CSM 全国网"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "CSM 52城"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(313, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 12)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "CSM 35城"
        '
        'Label_CSMALL
        '
        Me.Label_CSMALL.AutoSize = True
        Me.Label_CSMALL.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_CSMALL.ForeColor = System.Drawing.Color.Green
        Me.Label_CSMALL.Location = New System.Drawing.Point(178, 87)
        Me.Label_CSMALL.Name = "Label_CSMALL"
        Me.Label_CSMALL.Size = New System.Drawing.Size(18, 12)
        Me.Label_CSMALL.TabIndex = 9
        Me.Label_CSMALL.Text = "√"
        '
        'Label_CSM52
        '
        Me.Label_CSM52.AutoSize = True
        Me.Label_CSM52.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_CSM52.ForeColor = System.Drawing.Color.Green
        Me.Label_CSM52.Location = New System.Drawing.Point(275, 87)
        Me.Label_CSM52.Name = "Label_CSM52"
        Me.Label_CSM52.Size = New System.Drawing.Size(18, 12)
        Me.Label_CSM52.TabIndex = 9
        Me.Label_CSM52.Text = "√"
        '
        'Label_CSM35
        '
        Me.Label_CSM35.AutoSize = True
        Me.Label_CSM35.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_CSM35.ForeColor = System.Drawing.Color.Green
        Me.Label_CSM35.Location = New System.Drawing.Point(372, 87)
        Me.Label_CSM35.Name = "Label_CSM35"
        Me.Label_CSM35.Size = New System.Drawing.Size(18, 12)
        Me.Label_CSM35.TabIndex = 9
        Me.Label_CSM35.Text = "√"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 638)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_Cookie_35)
        Me.Controls.Add(Me.TextBox_Cookie_52)
        Me.Controls.Add(Me.TextBox_Cookie_quanguo)
        Me.Controls.Add(Me.Label_SavePath)
        Me.Controls.Add(Me.Label_SaveAs)
        Me.Controls.Add(Me.Button_SaveAs)
        Me.Controls.Add(Me.Button_OpenFile)
        Me.Controls.Add(Me.Button_Stop)
        Me.Controls.Add(Me.Button_Start)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView_Data)
        Me.Controls.Add(Me.GroupBox_C1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_CSMLink)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_KuyunEYELink)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "收视率实时监测"
        Me.GroupBox_C1.ResumeLayout(False)
        Me.GroupBox_C1.PerformLayout()
        CType(Me.DataGridView_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_KuyunEYELink As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_CSMLink As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox_C1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView_Data As System.Windows.Forms.DataGridView
    Friend WithEvents 序号 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 时间 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_Time As System.Windows.Forms.Label
    Friend WithEvents Button_Start As System.Windows.Forms.Button
    Friend WithEvents Button_Stop As System.Windows.Forms.Button
    Friend WithEvents Button_OpenFile As System.Windows.Forms.Button
    Friend WithEvents Button_SaveAs As System.Windows.Forms.Button
    Friend WithEvents Label_SaveAs As System.Windows.Forms.Label
    Friend WithEvents Label_SavePath As System.Windows.Forms.Label
    Friend WithEvents CheckBox_C3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_C2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_C1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox_Cookie_quanguo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Cookie_52 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Cookie_35 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer_SysTime As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Timer_CreateRow As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label_CSM35 As Label
    Friend WithEvents Label_CSM52 As Label
    Friend WithEvents Label_CSMALL As Label
    Friend WithEvents Label_kuyun_state As Label
    Friend WithEvents Label7 As Label
End Class
