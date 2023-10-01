using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using PowerApps.DataSync.Tool.Models;
using System;

namespace PowerApps.DataSync.UnitTests
{
    [TestClass]
    public class ValueComparerTests
    {
        [TestMethod]
        public void ValueComparer_Matches_For_Both_Do_Not_Have_Attribute()
        {
            //Arrange
            var source = new Entity();
            var target = new Entity();
            
            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueComparer_Does_Not_Match_For_One_Has_And_Other_Does_Not_Have_Attribute()
        {
            //Arrange
            var source = new Entity();
            source.Attributes.Add("rob_field", "FooBar");

            var target = new Entity();

            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValueComparer_Matches_For_Strings()
        {
            //Arrange
            var source = new Entity();
            source.Attributes.Add("rob_field", "FooBar");

            var target = new Entity();
            target.Attributes.Add("rob_field", "FooBar");

            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueComparer_Does_Not_Match_For_Strings()
        {
            //Arrange
            var source = new Entity();
            source.Attributes.Add("rob_field", "FooBar");

            var target = new Entity();
            target.Attributes.Add("rob_field", "FooBar2");

            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValueComparer_Matches_For_Decimal()
        {
            //Arrange
            var source = new Entity();
            source.Attributes.Add("rob_field", 1.23M);

            var target = new Entity();
            target.Attributes.Add("rob_field", 1.23M);

            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueComparer_Does_Not_Match_For_Decimal()
        {
            //Arrange
            var source = new Entity();
            source.Attributes.Add("rob_field", 1.23M);

            var target = new Entity();
            target.Attributes.Add("rob_field", 1.24M);

            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValueComparer_Matches_For_Bool()
        {
            //Arrange
            var source = new Entity();
            source.Attributes.Add("rob_field", true);

            var target = new Entity();
            target.Attributes.Add("rob_field", true);

            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueComparer_Does_Not_Match_For_Bool()
        {
            //Arrange
            var source = new Entity();
            source.Attributes.Add("rob_field", true);

            var target = new Entity();
            target.Attributes.Add("rob_field", false);

            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValueComparer_Matches_For_OptionSets()
        {
            //Arrange
            var source = new Entity();
            source.Attributes.Add("rob_field", new OptionSetValue(1));

            var target = new Entity();
            target.Attributes.Add("rob_field", new OptionSetValue(1));

            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueComparer_Does_Not_Match_For_OptionSets()
        {
            //Arrange
            var source = new Entity();
            source.Attributes.Add("rob_field", new OptionSetValue(2));

            var target = new Entity();
            target.Attributes.Add("rob_field", new OptionSetValue(3));

            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValueComparer_Matches_For_Money()
        {
            //Arrange
            var source = new Entity();
            source.Attributes.Add("rob_field", new Money(1.23M));

            var target = new Entity();
            target.Attributes.Add("rob_field", new Money(1.23M));

            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueComparer_Does_Not_Match_For_Money()
        {
            //Arrange
            var source = new Entity();
            source.Attributes.Add("rob_field", new Money(1.24M));

            var target = new Entity();
            target.Attributes.Add("rob_field", new Money(1.23M));

            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValueComparer_Matches_For_EntityReference()
        {
            //Arrange
            var refId = Guid.NewGuid();
            var source = new Entity();
            source.Attributes.Add("rob_field", new EntityReference("rob_foo", refId));

            var target = new Entity();
            target.Attributes.Add("rob_field", new EntityReference("rob_foo", refId));

            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueComparer_Does_Not_Match_For_EntityReference()
        {
            //Arrange
            var refId = Guid.NewGuid();
            var altRefId = Guid.NewGuid();
            var source = new Entity();
            source.Attributes.Add("rob_field", new EntityReference("rob_foo", refId));

            var target = new Entity();
            target.Attributes.Add("rob_field", new EntityReference("rob_foo", altRefId));
            //Act
            var result = ValueComparer.Compare(source, target, "rob_field");

            //Assert
            Assert.IsFalse(result);
        }
    }
}
