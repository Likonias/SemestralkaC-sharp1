
using Microsoft.VisualBasic.ApplicationServices;
using SemestralkaLibrary;
using SemestralkaMaybe.Entities;

namespace SemestralkaMaybe
{
    public partial class BooklistLogin : Form
    {
        private List<UserEntity> savedUsers = new List<UserEntity>();
        public BooklistLogin()
        {
            SaveUserEntity();
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            foreach (UserEntity user in savedUsers)
            {
                if (user.UserName.Equals(textBoxUsername.Text))
                {
                    PasswordHash passwordHash = new PasswordHash();
                    if(user.Password.Equals(passwordHash.PasswordHashing(textBoxPassword.Text))) 
                    { 
                        this.Close();
                        BooklistMain booklistMain = new BooklistMain(user);
                        booklistMain.ShowDialog();
                        return;
                    }

                }
            }

            MessageBox.Show("Invalid User!");

        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            BooklistNewUser newUser = new BooklistNewUser();
            newUser.ShowDialog();
            UserEntity createdUser = newUser.user;
            savedUsers.Add(createdUser);
        }

        private void SaveUserEntity()
        {
            FileSerializerDeserializer<UserEntity> fileSerializerDeserializer = new FileSerializerDeserializer<UserEntity>(savedUsers, "userEntityData.user");
            fileSerializerDeserializer.Save();
        }

        private void LoadUserEntity()
        {

        }
    }
}