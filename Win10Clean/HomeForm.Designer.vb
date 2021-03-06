﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.HomeTab = New System.Windows.Forms.TabPage()
        Me.ContextBtn = New System.Windows.Forms.Button()
        Me.AppKeepBtn = New System.Windows.Forms.Button()
        Me.VerLabel = New System.Windows.Forms.Label()
        Me.CheckUpdatesBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.AdsBtn = New System.Windows.Forms.Button()
        Me.HomeGroupBtn = New System.Windows.Forms.Button()
        Me.DefenderBtn = New System.Windows.Forms.Button()
        Me.OneDriveBtn = New System.Windows.Forms.Button()
        Me.Revert7Btn = New System.Windows.Forms.Button()
        Me.MetroTab = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.AllUserBox = New System.Windows.Forms.CheckBox()
        Me.UninstallBtn = New System.Windows.Forms.Button()
        Me.AppBox = New System.Windows.Forms.ListBox()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.ExportBtn = New System.Windows.Forms.Button()
        Me.DebugBox = New System.Windows.Forms.RichTextBox()
        Me.Tab3 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.HomeTab.SuspendLayout()
        Me.MetroTab.SuspendLayout()
        Me.Tab2.SuspendLayout()
        Me.Tab3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.HomeTab)
        Me.TabControl1.Controls.Add(Me.MetroTab)
        Me.TabControl1.Controls.Add(Me.Tab2)
        Me.TabControl1.Controls.Add(Me.Tab3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(537, 414)
        Me.TabControl1.TabIndex = 0
        '
        'HomeTab
        '
        Me.HomeTab.Controls.Add(Me.ContextBtn)
        Me.HomeTab.Controls.Add(Me.AppKeepBtn)
        Me.HomeTab.Controls.Add(Me.VerLabel)
        Me.HomeTab.Controls.Add(Me.CheckUpdatesBtn)
        Me.HomeTab.Controls.Add(Me.CloseBtn)
        Me.HomeTab.Controls.Add(Me.AdsBtn)
        Me.HomeTab.Controls.Add(Me.HomeGroupBtn)
        Me.HomeTab.Controls.Add(Me.DefenderBtn)
        Me.HomeTab.Controls.Add(Me.OneDriveBtn)
        Me.HomeTab.Controls.Add(Me.Revert7Btn)
        Me.HomeTab.Location = New System.Drawing.Point(4, 25)
        Me.HomeTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HomeTab.Name = "HomeTab"
        Me.HomeTab.Size = New System.Drawing.Size(529, 385)
        Me.HomeTab.TabIndex = 0
        Me.HomeTab.Text = "Home"
        Me.HomeTab.UseVisualStyleBackColor = True
        '
        'ContextBtn
        '
        Me.ContextBtn.Location = New System.Drawing.Point(306, 72)
        Me.ContextBtn.Name = "ContextBtn"
        Me.ContextBtn.Size = New System.Drawing.Size(220, 31)
        Me.ContextBtn.TabIndex = 26
        Me.ContextBtn.Text = "Cleanup context menu"
        Me.ToolTip1.SetToolTip(Me.ContextBtn, "Disables unnecessary stuff in the extra right-click menus, like printing and edit" &
        "ing in Notepad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.ContextBtn.UseVisualStyleBackColor = False
        '
        'AppKeepBtn
        '
        Me.AppKeepBtn.Location = New System.Drawing.Point(8, 108)
        Me.AppKeepBtn.Name = "AppKeepBtn"
        Me.AppKeepBtn.Size = New System.Drawing.Size(220, 31)
        Me.AppKeepBtn.TabIndex = 7
        Me.AppKeepBtn.Text = "Don't reinstall uninstalled apps"
        Me.ToolTip1.SetToolTip(Me.AppKeepBtn, "Stop Windows from re-installing pre-installed apps you just uninstalled")
        Me.AppKeepBtn.UseVisualStyleBackColor = True
        '
        'VerLabel
        '
        Me.VerLabel.AutoSize = True
        Me.VerLabel.Location = New System.Drawing.Point(8, 359)
        Me.VerLabel.Name = "VerLabel"
        Me.VerLabel.Size = New System.Drawing.Size(64, 17)
        Me.VerLabel.TabIndex = 25
        Me.VerLabel.Text = "Version: "
        '
        'CheckUpdatesBtn
        '
        Me.CheckUpdatesBtn.Location = New System.Drawing.Point(380, 352)
        Me.CheckUpdatesBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckUpdatesBtn.Name = "CheckUpdatesBtn"
        Me.CheckUpdatesBtn.Size = New System.Drawing.Size(79, 31)
        Me.CheckUpdatesBtn.TabIndex = 23
        Me.CheckUpdatesBtn.Text = "Updates"
        Me.CheckUpdatesBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(465, 352)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(61, 31)
        Me.CloseBtn.TabIndex = 24
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'AdsBtn
        '
        Me.AdsBtn.Location = New System.Drawing.Point(306, 2)
        Me.AdsBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AdsBtn.Name = "AdsBtn"
        Me.AdsBtn.Size = New System.Drawing.Size(220, 31)
        Me.AdsBtn.TabIndex = 2
        Me.AdsBtn.Text = "Disable start menu ads"
        Me.ToolTip1.SetToolTip(Me.AdsBtn, "Disables ads on the start menu, will only disable for the current user")
        Me.AdsBtn.UseVisualStyleBackColor = True
        '
        'HomeGroupBtn
        '
        Me.HomeGroupBtn.Location = New System.Drawing.Point(8, 72)
        Me.HomeGroupBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HomeGroupBtn.Name = "HomeGroupBtn"
        Me.HomeGroupBtn.Size = New System.Drawing.Size(220, 31)
        Me.HomeGroupBtn.TabIndex = 5
        Me.HomeGroupBtn.Text = "Disable HomeGroup"
        Me.ToolTip1.SetToolTip(Me.HomeGroupBtn, "Please leave your current HomeGroup first!")
        Me.HomeGroupBtn.UseVisualStyleBackColor = True
        '
        'DefenderBtn
        '
        Me.DefenderBtn.Location = New System.Drawing.Point(8, 2)
        Me.DefenderBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DefenderBtn.Name = "DefenderBtn"
        Me.DefenderBtn.Size = New System.Drawing.Size(220, 31)
        Me.DefenderBtn.TabIndex = 1
        Me.DefenderBtn.Text = "Disable Windows Defender"
        Me.ToolTip1.SetToolTip(Me.DefenderBtn, "Please only disable Defender if you have another strong anti-malware program, res" &
        "tart for changes to take effect" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.DefenderBtn.UseVisualStyleBackColor = True
        '
        'OneDriveBtn
        '
        Me.OneDriveBtn.Location = New System.Drawing.Point(306, 37)
        Me.OneDriveBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OneDriveBtn.Name = "OneDriveBtn"
        Me.OneDriveBtn.Size = New System.Drawing.Size(220, 31)
        Me.OneDriveBtn.TabIndex = 4
        Me.OneDriveBtn.Text = "Uninstall OneDrive"
        Me.ToolTip1.SetToolTip(Me.OneDriveBtn, "Complete uninstall of OneDrive, quick and no trouble")
        Me.OneDriveBtn.UseVisualStyleBackColor = True
        '
        'Revert7Btn
        '
        Me.Revert7Btn.Location = New System.Drawing.Point(8, 37)
        Me.Revert7Btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Revert7Btn.Name = "Revert7Btn"
        Me.Revert7Btn.Size = New System.Drawing.Size(220, 31)
        Me.Revert7Btn.TabIndex = 3
        Me.Revert7Btn.Text = "Revert explorer to Win7 style"
        Me.ToolTip1.SetToolTip(Me.Revert7Btn, "Remove unnecessary folders in My PC, shows the libary folder, stops quick access " &
        "from filling up and explorer defaults to open My PC")
        Me.Revert7Btn.UseVisualStyleBackColor = True
        '
        'MetroTab
        '
        Me.MetroTab.Controls.Add(Me.CheckBox2)
        Me.MetroTab.Controls.Add(Me.AllUserBox)
        Me.MetroTab.Controls.Add(Me.UninstallBtn)
        Me.MetroTab.Controls.Add(Me.AppBox)
        Me.MetroTab.Controls.Add(Me.RefreshBtn)
        Me.MetroTab.Location = New System.Drawing.Point(4, 25)
        Me.MetroTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MetroTab.Name = "MetroTab"
        Me.MetroTab.Size = New System.Drawing.Size(529, 385)
        Me.MetroTab.TabIndex = 1
        Me.MetroTab.Text = "Win10 / metro apps"
        Me.MetroTab.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(376, 30)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(145, 21)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Delete from image"
        Me.ToolTip1.SetToolTip(Me.CheckBox2, "Delete the app(s) from the system image, currently not implemented")
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'AllUserBox
        '
        Me.AllUserBox.AutoSize = True
        Me.AllUserBox.Location = New System.Drawing.Point(376, 2)
        Me.AllUserBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AllUserBox.Name = "AllUserBox"
        Me.AllUserBox.Size = New System.Drawing.Size(84, 21)
        Me.AllUserBox.TabIndex = 9
        Me.AllUserBox.Text = "All users"
        Me.ToolTip1.SetToolTip(Me.AllUserBox, "View apps for all the users (default is only current user)")
        Me.AllUserBox.UseVisualStyleBackColor = True
        '
        'UninstallBtn
        '
        Me.UninstallBtn.Image = Global.Win10Clean.My.Resources.Resources.bin
        Me.UninstallBtn.Location = New System.Drawing.Point(339, 350)
        Me.UninstallBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UninstallBtn.Name = "UninstallBtn"
        Me.UninstallBtn.Size = New System.Drawing.Size(32, 32)
        Me.UninstallBtn.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.UninstallBtn, "Uninstall selected app")
        Me.UninstallBtn.UseVisualStyleBackColor = True
        '
        'AppBox
        '
        Me.AppBox.FormattingEnabled = True
        Me.AppBox.ItemHeight = 16
        Me.AppBox.Location = New System.Drawing.Point(3, 2)
        Me.AppBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AppBox.Name = "AppBox"
        Me.AppBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.AppBox.Size = New System.Drawing.Size(367, 340)
        Me.AppBox.TabIndex = 5
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Image = Global.Win10Clean.My.Resources.Resources.arrow_refresh
        Me.RefreshBtn.Location = New System.Drawing.Point(300, 350)
        Me.RefreshBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(32, 32)
        Me.RefreshBtn.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.RefreshBtn, "Refresh the app list")
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'Tab2
        '
        Me.Tab2.Controls.Add(Me.ExportBtn)
        Me.Tab2.Controls.Add(Me.DebugBox)
        Me.Tab2.Location = New System.Drawing.Point(4, 25)
        Me.Tab2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Size = New System.Drawing.Size(529, 385)
        Me.Tab2.TabIndex = 2
        Me.Tab2.Text = "Console"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'ExportBtn
        '
        Me.ExportBtn.Location = New System.Drawing.Point(465, 352)
        Me.ExportBtn.Name = "ExportBtn"
        Me.ExportBtn.Size = New System.Drawing.Size(61, 31)
        Me.ExportBtn.TabIndex = 1
        Me.ExportBtn.Text = "Export"
        Me.ToolTip1.SetToolTip(Me.ExportBtn, "Export the console logs to a generic text file (.txt format)")
        Me.ExportBtn.UseVisualStyleBackColor = True
        '
        'DebugBox
        '
        Me.DebugBox.Location = New System.Drawing.Point(2, 2)
        Me.DebugBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DebugBox.Name = "DebugBox"
        Me.DebugBox.ReadOnly = True
        Me.DebugBox.Size = New System.Drawing.Size(523, 345)
        Me.DebugBox.TabIndex = 0
        Me.DebugBox.Text = ""
        '
        'Tab3
        '
        Me.Tab3.Controls.Add(Me.RichTextBox1)
        Me.Tab3.Location = New System.Drawing.Point(4, 25)
        Me.Tab3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tab3.Name = "Tab3"
        Me.Tab3.Size = New System.Drawing.Size(529, 385)
        Me.Tab3.TabIndex = 3
        Me.Tab3.Text = "About"
        Me.Tab3.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(533, 395)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 414)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(555, 461)
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Win10Clean"
        Me.TabControl1.ResumeLayout(False)
        Me.HomeTab.ResumeLayout(False)
        Me.HomeTab.PerformLayout()
        Me.MetroTab.ResumeLayout(False)
        Me.MetroTab.PerformLayout()
        Me.Tab2.ResumeLayout(False)
        Me.Tab3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents HomeTab As TabPage
    Friend WithEvents MetroTab As TabPage
    Friend WithEvents Tab2 As TabPage
    Friend WithEvents Tab3 As TabPage
    Friend WithEvents AdsBtn As Button
    Friend WithEvents HomeGroupBtn As Button
    Friend WithEvents DefenderBtn As Button
    Friend WithEvents OneDriveBtn As Button
    Friend WithEvents Revert7Btn As Button
    Friend WithEvents UninstallBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents AppBox As ListBox
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents VerLabel As Label
    Friend WithEvents CheckUpdatesBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents AllUserBox As CheckBox
    Friend WithEvents DebugBox As RichTextBox
    Friend WithEvents AppKeepBtn As Button
    Friend WithEvents ContextBtn As Button
    Friend WithEvents ExportBtn As Button
End Class
