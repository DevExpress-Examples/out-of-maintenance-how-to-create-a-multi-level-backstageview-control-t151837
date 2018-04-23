Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication12
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            'Parent BackstageView controls' tab appearances
            backstageViewControl1.Appearance.BackColor = Color.Black
            backstageViewControl1.Appearance.ForeColor = Color.White
            For Each tab As BackstageViewTabItem In backstageViewControl1.Items.OfType(Of BackstageViewTabItem)()
                tab.AppearanceSelected.BackColor = Color.DarkOrange
                tab.AppearanceSelected.ForeColor = Color.Black
                tab.AppearanceHover.BackColor = Color.DimGray
            Next tab
            'Child BackstageView controls' tab appearances
            Dim tabs2 As IEnumerable(Of BackstageViewTabItem) = backstageViewControl2.Items.OfType(Of BackstageViewTabItem)()
            Dim tabs3 As IEnumerable(Of BackstageViewTabItem) = backstageViewControl3.Items.OfType(Of BackstageViewTabItem)()
            Dim tabs4 As IEnumerable(Of BackstageViewTabItem) = backstageViewControl4.Items.OfType(Of BackstageViewTabItem)()
            For Each tab As BackstageViewTabItem In tabs2.Concat(tabs3.Concat(tabs4))
                tab.AppearanceSelected.BackColor = Color.White
                tab.AppearanceSelected.ForeColor = Color.Black
                tab.AppearanceHover.BackColor = Color.SandyBrown
            Next tab
        End Sub

        Private Sub backstageViewButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs) Handles backstageViewButtonItem1.ItemClick
            Me.Close()
        End Sub
    End Class
End Namespace
