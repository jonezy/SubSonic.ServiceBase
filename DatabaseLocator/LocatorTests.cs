using NUnit.Framework;

using DatabaseLocator;

namespace StorageLayer.Tests {
    #region example code
    public interface IStorageLayer {
        void Store(object o);
    }
    public interface IExampleImplementation : IStorageLayer { }
    public class ExampleImplementation : IExampleImplementation {
        public ExampleImplementation() {

        }

        public void Store(object o) {

        }
    }
    public interface IOtherExampleImplementation : IStorageLayer { } 
    #endregion

    [TestFixture]
    public class StorageLayerTest {
        [SetUp]
        public void Setup() {
            RegisterEndPoints(DatabaseTable.Databases);
        }

        [TearDown]
        public void Teardown() {
            DatabaseTable.Databases.Clear();
        }

        [Test]
        public void add_single_endpoints_should_do_return_count_1() {
            Assert.AreEqual(DatabaseTable.Databases.Count, 1);
        }
        
        [Test]
        public void add_2_endpoints_should_do_return_count_2() {
            DatabaseTable.Databases.Clear();
            RegisterMultipleEndpoints(DatabaseTable.Databases, 2);
            Assert.AreEqual(DatabaseTable.Databases.Count, 2);
        }

        [Test]
        public void clearing_storageendpoints_should_return_count_0() {
            DatabaseTable.Databases.Clear();
            Assert.AreEqual(0, DatabaseTable.Databases.Count);
        }

        [Test]
        public void retreived_endpoint_should_not_be_null() {
            IExampleImplementation example = Locator.Instance.GetEndPoint<IExampleImplementation>();

            Assert.NotNull(example);
        }

        [Test]
        public void retreived_endpoint_should_match_added_endpoint() {
            IExampleImplementation example = Locator.Instance.GetEndPoint<IExampleImplementation>();
            
            Assert.IsInstanceOf<IExampleImplementation>(example);
        }

        [Test]
        public void retreived_endpoint_should_be_null_if_not_found() {
            IOtherExampleImplementation example = Locator.Instance.GetEndPoint<IOtherExampleImplementation>();

            Assert.Null(example);
        }

        void RegisterEndPoints(DatabaseCollection endPoints) {
             endPoints.MapStorageEndPoint(typeof(IExampleImplementation), typeof(ExampleImplementation));
        }

        void RegisterMultipleEndpoints(DatabaseCollection endPoints, int count) {
            endPoints.MapStorageEndPoint(typeof(IExampleImplementation), typeof(ExampleImplementation));
            endPoints.MapStorageEndPoint(typeof(IOtherExampleImplementation), typeof(ExampleImplementation));
        }

    }
}
