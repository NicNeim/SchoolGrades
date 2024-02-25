using NUnitDbTests;
using SchoolGrades;

namespace NUnit_Tests
{
    public class T_Database_GeneralOperations
    {
        [SetUp]
        public void Setup()
        {
            //// business layer to test 
            //Test_Commons.bl = new BusinessLayer();
#if SQL_SERVER
            Test_Commons.dl = new SqlServer_DataLayer("SchoolGrades");
#else
            Helpers.dl = new SqLite_DataLayer();
#endif 
        }
        //[Test]
        //public void T_CreateNewDatabaseFromExisting()
        //{
        //    Commons.PathAndFileDatabase = Test_Commons.dbStandard;
        //    Test_Commons.bl.CreateNewDatabase(Test_Commons.dbTest);
        //    Assert.That(Test_Commons.dl.ReadFirstRowFirstField("Students") == null);
        //    Assert.That(Test_Commons.dl.ReadFirstRowFirstField("Lessons") == null);
        //}
        //[Test]
        //public void T_RecoverDatabaseFromStandard()
        //{
        //    Test_Commons.T_RecoverStandardDb();
        //    Assert.That(Test_Commons.dl.ReadFirstRowFirstField("Students") != null);
        //    Assert.That(Test_Commons.dl.ReadFirstRowFirstField("Lessons") != null);
        //}
    }
}