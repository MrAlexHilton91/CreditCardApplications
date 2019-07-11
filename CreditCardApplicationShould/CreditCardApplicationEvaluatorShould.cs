using CreditCardApplications;
using Xunit;

namespace CreditCardApplicationShould
{
    public class CreditCardApplicationEvaluatorShould
    {
        [Fact]
        public void AcceptHighIncomeApplications()
        {
            //Arrange
            var sut = new CreditCardApplicationEvaluator(null);
            var application = new CreditCardApplication { GrossAnnualIncome = 100_000 };

            //Act
            CreditCardApplicationDecision decision = sut.Evaluate(application);

            //Assert
            Assert.Equal(CreditCardApplicationDecision.AutoAccepted, decision);
        }

        [Fact]
        public void ReferYoungApplicants()
        {
            //Arrange
            var sut = new CreditCardApplicationEvaluator(null);
            var application = new CreditCardApplication { Age = 19 };

            //Act
            CreditCardApplicationDecision decision = sut.Evaluate(application);


            //Assert
            Assert.Equal(CreditCardApplicationDecision.ReferredToHuman, decision);
        }


    }
}