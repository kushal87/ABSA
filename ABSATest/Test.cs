using ABSA;
using ABSA.UserDetails.Model;
using ABSA.UserDetails.ViewModel;
using NUnit.Framework;
using System;
namespace ABSATest
{
    [TestFixture()]
    public class ABSAUserTest
    {
        private UserValidationViewModel _validationViewModel;
        private PeopleViewModel _peopleViewModel;
        
        public void SetUp()
        {
            _validationViewModel = new UserValidationViewModel("111111");
            _peopleViewModel = new PeopleViewModel();
        }

        [Test()]
        public void validateUser_WhenCalled_UserShouldBeValidated()
        {
            Assert.AreEqual(true, _validationViewModel.isValidNumber());            
        }

        [Test()]
        public async void getResponse_WhenCalled_UserShouldBeInList()
        {
            PeopleResponse peopleResponse = await _peopleViewModel.callABSAWebService();
            Assert.AreNotEqual(0, peopleResponse.results.Count);
        }
    }


}
