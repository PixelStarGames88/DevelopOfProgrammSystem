namespace MasterOfArrays;

public partial class MessageForm : Form
{
    public MessageForm(string messageText, string title)
    {
        InitializeComponent();
        this.Text = title;
        MessageLabel.Text = messageText;
    }

    private void ButtonOK_Click(object sender, EventArgs e)
    {
        Close();
    }
}
