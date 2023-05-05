
using BankSystemModel;

namespace BankSystemTestProject
{
    [TestClass]
    public class ClientListTest
    {
        [TestMethod]
        public void Add_correct()
        {
            //Arrange
            ClientList clientList = new ClientList();

            //Act
            bool actual = clientList.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Add_not_correct()
        {
            //Arrange
            ClientList clientList = new ClientList();
            clientList.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            //Act
            bool actual = clientList.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Remove_correct()
        {
            //Arrange
            ClientList clientList = new ClientList();
            clientList.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            //Act
            bool actual = clientList.Remove(1234567890);
            
            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Remove_not_correct()
        {
            //Arrange
            ClientList clientList = new ClientList();
            clientList.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            //Act
            bool actual = clientList.Remove(1234567891);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Update_correct()
        {
            //Arrange
            ClientList clientList = new ClientList();
            clientList.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            //Act
            bool actual = clientList.Update("Михайло", "Басманов", 1234567890, "789452159", "+380456789025", "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Update_not_correct()
        {
            //Arrange
            ClientList clientList = new ClientList();
            clientList.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            //Act
            bool actual = clientList.Update("Михайло", "Басманов", 1234568890, "789452159", "+380456789025", "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void FindByInp_correct()
        {
            //Arrange
            ClientList clientList = new ClientList();
            clientList.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            Client client = new Client("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            string expected = client.ToString();

            //Act
            string actual = clientList.FindByInp(1234567890).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SerializeObject_correct()
        {
            //Arrange
            ClientList clientList = new ClientList();
            clientList.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            string path = "clients";

            //Act
            bool actual = clientList.SerializeObject(path);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SerializeObject_not_correct()
        {
            //Arrange
            ClientList clientList = new ClientList();
            clientList.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");

            string path = "/";

            //Act & Assert
            Assert.ThrowsException<Exception>(() => clientList.SerializeObject(path));
        }

        [TestMethod]
        public void DeserializeObject_correct()
        {
            //Arrange
            ClientList clientList = new ClientList();
            clientList.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            string path = "clients";
            clientList.SerializeObject(path);

            //Act
            bool actual = clientList.DeserializeObject(path);

            //Assert
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void DeserializeObject_not_correct()
        {
            //Arrange
            ClientList clientList = new ClientList();
            List<Client> result;
            clientList.Add("Михайло", "Басманов", "Петрович", 1234567890, "789452159", "+380456789025", Sex.male, new DateTime(1990, 1, 1), "м. Полтава, вул. Перемоги, буд. 23", "1234567890");
            string path = "clients";
            clientList.SerializeObject(path);

            //Act
            bool actual = clientList.DeserializeObject("/");

            //Assert
            Assert.IsFalse(actual);
        }
    }
}
