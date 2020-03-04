using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileManager.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Layer;
using System.IO;

namespace FileManager.DataAccess.Data.Tests
{
    [TestClass()]
    public class FileXMLTests
    {
        readonly string file = "./Students.xml";
        Student student = new Student(1, "nuevo student", "nuevo_apellido", 1890);
        Student student2 = new Student(2, "nuevo student", "nuevo_apellido", 1890);

        [TestCleanup]
        public void TearDown()
        {
            File.Delete(file);
        }

        [TestMethod()]
        public void CreateTest()
        {
           
            IFile XmlFile = FactoryProvider.getFactory(PersitenseTypes.FILE).Create(FileTypes.xml);
            Student addedStudent = XmlFile.Create(student);

            Assert.AreEqual(student, addedStudent);
        }
        [TestMethod()]
        public void DeleteTest()
        {
           
            IFile xmlFile = new FileXML();
            Student addedStudent = xmlFile.Create(student);
            Student addedStudent1 = xmlFile.Create(student2);

            bool response = xmlFile.Delete(addedStudent);
            Assert.IsTrue(response);

        }
        [TestMethod()]
        public void UpdateTest()
        {
            Assert.AreEqual(0, 0);
        }
    }
}