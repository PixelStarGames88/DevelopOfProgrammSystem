namespace SPBSIT__TU_;

public partial class TableForm : Form
{
    public TableForm(object[] Records)
    {
        InitializeComponent();
        FillByResults(Records);

    }

    private void ThankYouVeryMuchButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
