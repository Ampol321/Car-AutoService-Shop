Public Class MainMenu
    Dim manufacture As New Manufacturers
    Dim carmodel As New CarModel
    Dim cartype As New CarType
    Dim mechanics As New Mechanics
    Dim service As New Services
    Dim accessorie As New Parts
    Dim supplies As New Suppliers
    Dim vehicle As New Vehicles
    Dim customers As New Customers
    Dim search1 As New Quiz1
    Dim search2 As New Quiz2
    Dim search3 As New Quiz3
    Dim search4 As New Quiz4
    Dim search5 As New Quiz5
    Dim history As New SearchHistory
    Dim overall As New OverallIncome
    Dim range As New DateRangeIncome

    Private Sub ManufacturerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANUFACTURERToolStripMenuItem.Click
        manufacture.MdiParent = Me
        manufacture.Dock = DockStyle.Fill
        manufacture.Show()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub CarModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARMODELToolStripMenuItem.Click
        carmodel.MdiParent = Me
        carmodel.Dock = DockStyle.Fill
        carmodel.Show()
        manufacture.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub CarTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARTYPEToolStripMenuItem.Click
        cartype.MdiParent = Me
        cartype.Dock = DockStyle.Fill
        cartype.Show()
        manufacture.Hide()
        carmodel.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub MechanicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MECHANICSToolStripMenuItem.Click
        mechanics.MdiParent = Me
        mechanics.Dock = DockStyle.Fill
        mechanics.Show()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub ServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERVICESToolStripMenuItem.Click
        service.MdiParent = Me
        service.Dock = DockStyle.Fill
        service.Show()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub PartsAccessoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PARTSACCESSORIESToolStripMenuItem.Click
        accessorie.MdiParent = Me
        accessorie.Dock = DockStyle.Fill
        accessorie.Show()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUPPLIERSToolStripMenuItem.Click
        supplies.MdiParent = Me
        supplies.Dock = DockStyle.Fill
        supplies.Show()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        vehicle.Hide()
        customers.Hide()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub OwnersCarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OWNERSCARToolStripMenuItem.Click
        vehicle.MdiParent = Me
        vehicle.Dock = DockStyle.Fill
        vehicle.Show()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        customers.Hide()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERSToolStripMenuItem.Click
        customers.MdiParent = Me
        customers.Dock = DockStyle.Fill
        customers.Show()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub quiz1_Click(sender As Object, e As EventArgs) Handles quiz1.Click
        search1.MdiParent = Me
        search1.Dock = DockStyle.Fill
        search1.Show()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub quiz2_Click(sender As Object, e As EventArgs) Handles quiz2.Click
        search2.MdiParent = Me
        search2.Dock = DockStyle.Fill
        search2.Show()
        search1.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub quiz3_Click(sender As Object, e As EventArgs) Handles quiz3.Click
        search3.MdiParent = Me
        search3.Dock = DockStyle.Fill
        search3.Show()
        search1.Hide()
        search2.Hide()
        search4.Hide()
        search5.Hide()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub quiz4_Click(sender As Object, e As EventArgs) Handles quiz4.Click
        search4.MdiParent = Me
        search4.Dock = DockStyle.Fill
        search4.Show()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search5.Hide()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub quiz5_Click(sender As Object, e As EventArgs) Handles quiz5.Click
        search5.MdiParent = Me
        search5.Dock = DockStyle.Fill
        search5.Show()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        history.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub CUSTOMERHISTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERHISTORYToolStripMenuItem.Click
        history.MdiParent = Me
        history.Dock = DockStyle.Fill
        history.Show()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        overall.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub TOTALINCOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TOTALINCOMEToolStripMenuItem.Click
        overall.MdiParent = Me
        overall.Dock = DockStyle.Fill
        overall.Show()
        history.Hide()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        range.Hide()
        Picture.Visible = False
    End Sub

    Private Sub DATERANGEINCOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATERANGEINCOMEToolStripMenuItem.Click
        range.MdiParent = Me
        range.Dock = DockStyle.Fill
        range.Show()
        history.Hide()
        search1.Hide()
        search2.Hide()
        search3.Hide()
        search4.Hide()
        search5.Hide()
        manufacture.Hide()
        carmodel.Hide()
        cartype.Hide()
        mechanics.Hide()
        service.Hide()
        accessorie.Hide()
        supplies.Hide()
        vehicle.Hide()
        customers.Hide()
        overall.Hide()
        Picture.Visible = False
    End Sub
End Class