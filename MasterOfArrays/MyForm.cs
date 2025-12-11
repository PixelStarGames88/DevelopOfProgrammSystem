using System.Windows.Forms;

namespace MasterOfArrays;

public partial class MyForm : Form
{
    public MyForm()
    {
        InitializeComponent();
        AddingFunctionality();
    }
    private void Enter_Click(object o, EventArgs e)
    {
        if(!_dateBaseConnector.SignIsWellDone(_enterWindow.UserNameBox.Text, _enterWindow.PasswordBox.Text))
        {
            if(string.IsNullOrEmpty(_enterWindow.UserNameBox.Text))
            {
                MessageForm error = new MessageForm("Field of login is empty!", "Error");
                error.Show();
            }
            else if (string.IsNullOrEmpty(_enterWindow.PasswordBox.Text))
            {
                MessageForm error = new MessageForm("Field of password is empty!", "Error");
                error.Show();
            }
            else
            {
                MessageForm error = new MessageForm("Password or login is not correct!", "Error");
                error.Show();
            }
            return;
        }

        _workDesk.ChangeName(_enterWindow.UserNameBox.Text);
        _enterWindow.Close();
        _workDesk.Open();
        _arrayEditWindow.Open();
        _accEditorWindow.FillTextBoxes(_dateBaseConnector.CurrentFirstName, _dateBaseConnector.CurrentLastName,
                                  _dateBaseConnector.CurrentUserLogin, _dateBaseConnector.CurrentPassword);
    }
    private void ExitFromProgramm_Click(object o, EventArgs e)
    {
        Application.Exit();
    }
    private void NewAcc_Click(object o, EventArgs e)
    {
        _enterWindow.Close();
        _accountCreatingWindow.Open();
    }

    private void ExitFromRegistration_Click(object o, EventArgs e)
    {
        _accountCreatingWindow.Close();
        _enterWindow.Open();
    }
    private void Finish_Click(object o, EventArgs e)
    {
        if (_accountCreatingWindow.PasswordBox.Text != _accountCreatingWindow.RepeatPasswordBox.Text)
        {
            if(string.IsNullOrEmpty(_accountCreatingWindow.RepeatPasswordBox.Text))
            {
                MessageForm error = new MessageForm("Repeat password!", "Error");
                error.Show();
            }
            else
            {
                MessageForm error = new MessageForm("Repeat password correctly!", "Error");
                error.Show();
            }
                
            return; 
        }
        if (!(_dateBaseConnector.AddUser(_accountCreatingWindow.LoginNameBox.Text,
                                       _accountCreatingWindow.PasswordBox.Text,
                                       _accountCreatingWindow.FirstNameBox.Text,
                                       _accountCreatingWindow.LastNameBox.Text)))
        {
            if(string.IsNullOrEmpty(_accountCreatingWindow.LoginNameBox.Text))
            {
                MessageForm error = new MessageForm("Enter login!", "Error");
                error.Show();
            }
            else if (string.IsNullOrEmpty(_accountCreatingWindow.PasswordBox.Text))
            {
                MessageForm error = new MessageForm("Enter password!", "Error");
                error.Show();
            }
            else
            {
                MessageForm error = new MessageForm("Account with same login already exists!", "Error");
                error.Show();
            }  
            return; 
        }

        _workDesk.ChangeName(_accountCreatingWindow.LoginNameBox.Text);
        _accEditorWindow.FillTextBoxes(_dateBaseConnector.CurrentFirstName, _dateBaseConnector.CurrentLastName,
                                      _dateBaseConnector.CurrentUserLogin, _dateBaseConnector.CurrentPassword);
        _accountCreatingWindow.Close();
        _workDesk.Open();
        _arrayEditWindow.Open();
        
    }
    private void NewArray_Click(object o, EventArgs e)
    {
        _dateBaseConnector.CurrentArray = "";
        _workDesk.WorkField.Clear();
        _arrayEditor.ClearArray();
    }
    private void ExitFromAcc_Click(object o, EventArgs e)
    {
        _workDesk.Close();
        _enterWindow.Open();
    }
    private void OpenArray_Click(object o, EventArgs e)
    {
        _openArrayWindow.Open();
        _workDesk.Close();
        _openArrayWindow.AddButtons(_dateBaseConnector.UserArrays);
    }

    private void SaveArray_Click(object o, EventArgs e)
    {
        _saveArrayAsWindow.Open();
        _workDesk.Close();
        _saveArrayAsWindow.AddButtons(_dateBaseConnector.UserArrays);
    }
    private void DeleteArray_Click(object o, EventArgs e)
    {
        _deleteArrayWindow.Open();
        _workDesk.Close();
        _deleteArrayWindow.AddButtons(_dateBaseConnector.UserArrays);
    }

    private void EnterToEditAcc_Click(object o, EventArgs e)
    {
        _accEditorWindow.Open();
        _workDesk.Close();
    }

    private void ShowSortedArray_Click(object o, EventArgs e)
    {
        if (_arrayEditor.AddNumbersFromString(_workDesk.WorkField.Text))
        {
            _workDesk.WorkField.Text = _arrayEditor.GetStringSortedArray();
        }
        else
        {
            MessageForm error = new MessageForm("Format is not correct!", "Error");
            error.Show();
        }
    }
    private void ShowSourceArray_Click(object o, EventArgs e)
    {
        if (_arrayEditor.AddNumbersFromString(_workDesk.WorkField.Text))
        {
            _workDesk.WorkField.Text = _arrayEditor.GetStringSourceArray();
        }
        else
        {
            MessageForm error = new MessageForm("Format is not correct!", "Error");
            error.Show();
        }
    }
    private void FillRandomNumber_Click(object o, EventArgs e)
    {
        int firstLimit;
        int secondLimit;
        uint quantity;
        if(string.IsNullOrEmpty(_windowRandomNambers.firstLimitBox.Text) || 
           string.IsNullOrEmpty(_windowRandomNambers.lastLimitBox.Text) ||
           string.IsNullOrEmpty(_windowRandomNambers.Quantity.Text))
        {
            MessageForm error = new MessageForm("Fill empty fields!", "Error");
            error.Show();
            return;
        }
        else if (!(int.TryParse(_windowRandomNambers.firstLimitBox.Text, out firstLimit) &&
            int.TryParse(_windowRandomNambers.lastLimitBox.Text, out secondLimit) &&
            uint.TryParse(_windowRandomNambers.Quantity.Text, out quantity)))
        {
            MessageForm error = new MessageForm("Enter integer number!", "Error");
            error.Show();
            return;
        }
        else if (!uint.TryParse(_windowRandomNambers.Quantity.Text, out quantity) &&
            (int.TryParse(_windowRandomNambers.lastLimitBox.Text, out firstLimit) ||
             int.TryParse(_windowRandomNambers.firstLimitBox.Text, out secondLimit)))
        {
            MessageForm error = new MessageForm("Enter positive number!", "Error");
            error.Show();
            return;
        }
        else if(Math.Abs(firstLimit) > Constants.NUMBER_IN_ARRAY_LIMIT || Math.Abs(secondLimit) > Constants.NUMBER_IN_ARRAY_LIMIT)
        {
            MessageForm error = new MessageForm("Absolute numbers cannot be more than " + Constants.QUANTITY_LIMIT + "!", "Error");
            error.Show();
            return;
        }
        else if(quantity + _arrayEditor.GetArray.Length > Constants.QUANTITY_LIMIT)
        {
            MessageForm error = new MessageForm("You can add only " + (Constants.QUANTITY_LIMIT - _arrayEditor.GetArray.Length) + " numbers!", "Error");
            error.Show();
            return;
        }
        _arrayEditor.AddRandomNumbers(quantity, firstLimit, secondLimit);
        _workDesk.WorkField.Text = _arrayEditor.GetStringSourceArray();
        _windowRandomNambers.Close(); _arrayEditWindow.Open();
    }
    private void DownloadArray_Click(object o, EventArgs e)
    {
        _workDesk.Close();
        _downloadArrayWindow.Open();
        _downloadArrayWindow.AddButtons(_dateBaseConnector.UserArrays);
    }
    private void Clear_Click(object o, EventArgs e)
    {
        _workDesk.WorkField.Clear();
        _arrayEditor.ClearArray();
    }

    private void OpenRandomNumberWindow_Click(object o, EventArgs e)
    {
        _arrayEditWindow.Close();
        _windowRandomNambers.Open();
    }
    private void ExitFormRandNumWindow_Click(object o, EventArgs e)
    {
        _windowRandomNambers.Close();
        _arrayEditWindow.Open();
    }

    private void ChoiceArrayForSave_Click(object o, EventArgs e)
    {
        if (_arrayEditor.AddNumbersFromString(_workDesk.WorkField.Text))
        {
            if (_dateBaseConnector.AddArray(_workDesk.WorkField.Text, _saveArrayAsWindow.LastNameBox.Text))
            {
                _saveArrayAsWindow.Close();
                _workDesk.Open();
                MessageForm info = new MessageForm("New array was added!", "Info");
                info.Show();
            }
            else
            {
                if (_dateBaseConnector.UpdateArray(_workDesk.WorkField.Text, _saveArrayAsWindow.LastNameBox.Text))
                {
                    MessageForm info = new MessageForm("Array " + _saveArrayAsWindow.LastNameBox.Text + " was added!", "Info");
                    info.Show();
                    _saveArrayAsWindow.Close();
                    _workDesk.Open();
                }
                else
                {
                    MessageForm error = new MessageForm("This array not exist!", "Error");
                    error.Show();
                }
            }
        }
        else
        {
            MessageForm error = new MessageForm("Array has not numbers!", "Error");
            error.Show();
        }
    }
    private void CancelSaveArrayAs_Click(object o, EventArgs e)
    {

        _saveArrayAsWindow.Close();
        _workDesk.Open();
    }

    private void CancelOpenArray_Click(object o, EventArgs e)
    {
        _workDesk.Open();
        _openArrayWindow.Close();
    }
    private void ChoiceArrayForOpen_Click(object o, EventArgs e)
    {
        string ArrayString;

        if (_dateBaseConnector.GetArrayFromDB(out ArrayString, _openArrayWindow.LastNameBox.Text))
        {
            _workDesk.WorkField.Text = ArrayString;
            _openArrayWindow.Close();
            _workDesk.Open();
            MessageForm info = new MessageForm("Operation is success!", "Info");
            info.Show();
        }
        else
        {
            MessageForm error = new MessageForm("This array not exist!", "Error");
            error.Show();
        }

    }

    private void ChoiceArrayForDownload_Click(object o, EventArgs e)
    {
        string ArrayString;
        if (_dateBaseConnector.GetArrayFromDB(out ArrayString, _downloadArrayWindow.LastNameBox.Text))
        {
            _workDesk.WorkField.Text = _workDesk.WorkField.Text + ArrayString;
            _arrayEditor.AddNumbersFromString(_workDesk.WorkField.Text);
            _openArrayWindow.Close();
            _workDesk.Open();
            MessageForm info = new MessageForm("Operation is success!", "Info");
            info.Show();
        }
        else
        {
            MessageForm error = new MessageForm("This array not exist!", "Error");
            error.Show();
        }
    }
    private void CancelDownloadArray_Click(object o, EventArgs e)
    {
        _workDesk.Open();
        _downloadArrayWindow.Close();
    }

    private void ChoiceArrayForDelete_Click(object o, EventArgs e)
    {
        if (_dateBaseConnector.DeleteArray(_deleteArrayWindow.LastNameBox.Text))
        {
            _deleteArrayWindow.Close();
            _workDesk.Open();
            MessageForm info = new MessageForm("Operation is success!", "Info");
            info.Show();
        }
        else
        {
            MessageForm error = new MessageForm("This array not exist!", "Error");
            error.Show();
        }
    }
    private void CancelDeleteArray_Click(object o, EventArgs e)
    {
        _deleteArrayWindow.Close();
        _workDesk.Open();
    }

    private void BackToWorkDesk_Click(object o, EventArgs e)
    {
        _accEditorWindow.FillTextBoxes(_dateBaseConnector.CurrentFirstName, _dateBaseConnector.CurrentLastName,
                                      _dateBaseConnector.CurrentUserLogin, _dateBaseConnector.CurrentPassword);
        _workDesk.Open();
        _accEditorWindow.Close();
    }
    private void Apply_Click(object o, EventArgs e)
    {
        if(!_dateBaseConnector.ChangeUserData(_dateBaseConnector.CurrentUserLogin, _accEditorWindow.FirstNameTextBox.Text, 
            _accEditorWindow.LastNameTextBox.Text, _accEditorWindow.LoginTextBox.Text, _accEditorWindow.PasswordTextBox.Text))
        {
            if(string.IsNullOrEmpty(_accEditorWindow.PasswordTextBox.Text))
            {
                MessageForm error = new MessageForm("Field of password is empty!", "Error");
                error.Show();
            }
            else if (string.IsNullOrEmpty(_accEditorWindow.LoginTextBox.Text))
            {
                MessageForm error = new MessageForm("Field of login is empty!", "Error");
                error.Show();
            }
            else
            {
                MessageForm error = new MessageForm("Account with same login already exists!", "Error");
                error.Show();
            }
            return;
        }
        _accEditorWindow.Close();
        _workDesk.Open();
        _workDesk.ChangeName(_dateBaseConnector.CurrentUserLogin);
        MessageForm info = new MessageForm("Operation is success!", "Info");
        info.Show();
    }
    private void DeleteAcc_Click(object o, EventArgs e)
    {
        if(_dateBaseConnector.DeleteUser(_dateBaseConnector.CurrentUserLogin))
        {
            _accEditorWindow.Close();
            _enterWindow.Open();
            MessageForm info = new MessageForm("Operation is success!", "Info");
            info.Show();
        }
        else
        {
            MessageForm error = new MessageForm("Operation is not success!", "Error");
            error.Show();
        }
    }
    private void ExitFromAccount_Click(object o, EventArgs e)
    {
        _workDesk.Close();
        _enterWindow.Open();
    }
    private void ShowInfo_Click(object o, EventArgs e)
    {
        InfoForm infoForm = new InfoForm();
        infoForm.Show();
    }
}