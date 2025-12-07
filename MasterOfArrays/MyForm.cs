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
        if(!_dateBaseConnector.SignIsWellDone(_enterWindow.UserNameBox.Text, _enterWindow.passwordBox.Text))
        {
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
        if (_dateBaseConnector.AddUser(_accountCreatingWindow._loginNameBox.Text,
                                                      _accountCreatingWindow.PasswordBox.Text,
                                                      _accountCreatingWindow.FirstNameBox.Text,
                                                      _accountCreatingWindow.LastNameBox.Text)
            && _accountCreatingWindow.PasswordBox.Text == _accountCreatingWindow.RepeatPasswordBox.Text)
        {
            _workDesk.ChangeName(_accountCreatingWindow._loginNameBox.Text);
            _accountCreatingWindow.Close();
            _workDesk.Open();
            _arrayEditWindow.Open();
            _accEditorWindow.FillTextBoxes(_dateBaseConnector.CurrentFirstName, _dateBaseConnector.CurrentLastName,
                                      _dateBaseConnector.CurrentUserLogin, _dateBaseConnector.CurrentPassword);
        }
    }

    private void NewArray_Click(object o, EventArgs e)
    {
        _workDesk.WorkField.Clear();
        _arrayEditor.ClearArray();
        _dateBaseConnector.CurrentArray = "";
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
        if (_arrayEditor.AddNumbersFromString(_workDesk.WorkField.Text))
        {
            if (_dateBaseConnector.CurrentArray.Length == 0)
            {
                _saveArrayAsWindow.Open();
                _workDesk.Close();
                _saveArrayAsWindow.AddButtons(_dateBaseConnector.UserArrays);
            }
            else
            {
                if (_dateBaseConnector.UpdateArray(_arrayEditor.GetStringSourceArray(), _dateBaseConnector.CurrentArray))
                {
                    MessageBox.Show("The save is success!", "Info");
                }
                else
                {
                    MessageBox.Show("The save is not success!", "Info");
                }
            }
        }
        else
        {
            MessageBox.Show("Array has not numbers!", "Info");
        }
    }
    private void SaveArrayAs_Click(object o, EventArgs e)
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
            MessageBox.Show("¬веден не подход€щий формат!", "Error");
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
            MessageBox.Show("¬веден не подход€щий формат!", "Error");
        }
    }
    private void FillRandomNumber_Click(object o, EventArgs e)
    {
        int firstLimit;
        int secondLimit;
        uint quantity;
        if (int.TryParse(_windowRandomNambers.firstLimitBox.Text, out firstLimit) &&
            int.TryParse(_windowRandomNambers.lastLimitBox.Text, out secondLimit) &&
            uint.TryParse(_windowRandomNambers.Quantity.Text, out quantity))
        {
            _arrayEditor.AddRandomNumbers(quantity, firstLimit, secondLimit);
            _workDesk.WorkField.Text = _arrayEditor.GetStringSourceArray();
            _windowRandomNambers.Close(); _arrayEditWindow.Open();
        }
        else if (!uint.TryParse(_windowRandomNambers.Quantity.Text, out quantity) &&
            (int.TryParse(_windowRandomNambers.lastLimitBox.Text, out firstLimit) ||
             int.TryParse(_windowRandomNambers.firstLimitBox.Text, out secondLimit)))
        {
            MessageBox.Show("¬ведено отрицательное количество!", "Error");
        }
        else
        {
            MessageBox.Show("¬ведены не целые числа!", "Error");
        }
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
                MessageBox.Show("New array was added!", "Info");
            }
            else
            {
                if (_dateBaseConnector.UpdateArray(_workDesk.WorkField.Text, _saveArrayAsWindow.LastNameBox.Text))
                {
                    _saveArrayAsWindow.Close();
                    _workDesk.Open();
                    MessageBox.Show("Array " + _saveArrayAsWindow.LastNameBox.Text + " was added!", "Info");
                }
                else
                {
                    MessageBox.Show("This array not exist!", "Info");
                }
            }
        }
        else
        {
            MessageBox.Show("Array has not numbers!", "Info");
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
            MessageBox.Show("Operation is success!", "Info");
        }
        else
        {
            MessageBox.Show("This array not exist!", "Info");
        }

    }

    private void ChoiceArrayForDownload_Click(object o, EventArgs e)
    {
        string ArrayString;
        if (_dateBaseConnector.GetArrayFromDB(out ArrayString, _downloadArrayWindow.LastNameBox.Text))
        {
            _workDesk.WorkField.Text += ArrayString;
            _openArrayWindow.Close();
            _workDesk.Open();
            MessageBox.Show("Operation is success!", "Info");
        }
        else
        {
            MessageBox.Show("This array not exist!", "Info");
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
            MessageBox.Show("Operation is success!", "Info");
        }
        else
        {
            MessageBox.Show("This array not exist!", "Info");
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
        if(_dateBaseConnector.ChangeUserData(_dateBaseConnector.CurrentUserLogin, _accEditorWindow.FirstNameTextBox.Text, 
            _accEditorWindow.LastNameTextBox.Text, _accEditorWindow.LoginTextBox.Text, _accEditorWindow.PasswordTextBox.Text))
        {
            _accEditorWindow.Close();
            _workDesk.Open();
            _workDesk.ChangeName(_dateBaseConnector.CurrentUserLogin);
            MessageBox.Show("Operation is success!", "Info");
        }
        else
        {
            MessageBox.Show("Operation is not success!", "Info");
        }
    }
    private void DeleteAcc_Click(object o, EventArgs e)
    {
        if(_dateBaseConnector.DeleteUser(_dateBaseConnector.CurrentUserLogin))
        {
            _accEditorWindow.Close();
            _enterWindow.Open();
            MessageBox.Show("Operation is success!", "Info");
        }
        else
        {
            MessageBox.Show("Operation is not success!", "Info");
        }
    }
}
