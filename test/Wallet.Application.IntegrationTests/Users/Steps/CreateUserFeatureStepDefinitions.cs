namespace Wallet.Application.IntegrationTests.Users.Steps;

[Binding]
public sealed class CreateUserFeatureStepDefinitions
{
    
    private readonly ScenarioContext _scenarioContext;

    public CreateUserFeatureStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given(@"a user with name (\w+) and surname (\w+)")]
    public void GivenAUserWithNameIcaroAndSurnameSousa(string name, string surname)
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"try to save it at the database")]
    public void WhenTryToSaveItAtTheDatabase()
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"it is not at the database yet")]
    public void WhenItIsNotAtTheDatabaseYet()
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"it should be success")]
    public void ThenItShouldBeSuccess()
    {
        ScenarioContext.StepIsPending();
    }
}