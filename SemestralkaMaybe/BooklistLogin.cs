
using Microsoft.VisualBasic.ApplicationServices;
using SemestralkaLibrary;
using SemestralkaMaybe.Entities;

namespace SemestralkaMaybe
{
    public partial class BooklistLogin : Form
    {
        private EntitiesRecords entitiesRecords = new EntitiesRecords();
        private UserEntity selectedUser;
        public EntitiesRecords EntitiesRecords { get { return entitiesRecords; } }
        public UserEntity SelectedUser { get { return selectedUser; } }
        public bool exitClicked = false;
        public BooklistLogin()
        {
            try
            {
                LoadUserEntity();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            exitClicked = true;
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
                        selectedUser = user;
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
            BooklistNewUser newUser = new BooklistNewUser(entitiesRecords);
            newUser.ShowDialog();
            UserEntity createdUser = newUser.user;
            if(createdUser != null )
            {
                entitiesRecords.AddUser(createdUser);
                SaveUserEntity();
            }
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