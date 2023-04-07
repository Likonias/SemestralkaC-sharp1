
using Microsoft.VisualBasic.ApplicationServices;
using SemestralkaLibrary;
using SemestralkaMaybe.Entities;

namespace SemestralkaMaybe
{
    public partial class BooklistLogin : Form
    {
        private EntitiesRecords entitiesRecords = new EntitiesRecords();
        public BooklistLogin()
        {
            try
            {
                LoadUserEntity();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            SaveUserEntity();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            foreach (UserEntity user in entitiesRecords.UserEntities)
            {
                if (user.UserName.Equals(textBoxUsername.Text))
                {
                    string passHashed = PasswordHash.PasswordHashing(textBoxPassword.Text);
                    if (PasswordHash.IsPasswordCorrect(user.Password, passHashed))
                    {
                        
                        BooklistMain booklistMain = new BooklistMain(user);
                        booklistMain.Show();
                        this.Close();
                        return;
                    }
                    MessageBox.Show("Wrong Password!");
                    return;
                }
            }

            MessageBox.Show("Invalid User!");

        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            BooklistNewUser newUser = new BooklistNewUser();
            newUser.ShowDialog();
            UserEntity createdUser = newUser.user;
            entitiesRecords.AddUser(createdUser);
            SaveUserEntity();
        }

        private void SaveUserEntity()
        {
            FileSerializerDeserializer<UserEntity> fileSerializerDeserializer = new FileSerializerDeserializer<UserEntity>(entitiesRecords, "userEntityData.user");
            fileSerializerDeserializer.Save();
        }

        private void LoadUserEntity()
        {
            FileSerializerDeserializer<UserEntity> fileSerializerDeserializer = new FileSerializerDeserializer<UserEntity>(entitiesRecords, "userEntityData.user");
            fileSerializerDeserializer.Load();
        }
    }
}