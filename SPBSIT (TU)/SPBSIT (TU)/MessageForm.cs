namespace SPBSIT__TU_;

public partial class MessageForm : Form
{
    public MessageForm(string messageText, string title)
    {
        InitializeComponent();
        this.Text = title;
        _messageLabel.Text = messageText;
    }

    private void ButtonOK_Click(object sender, EventArgs e)
    {
        Close();
    }
}
