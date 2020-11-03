using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebDriver.CSharp.Solution.Pages
{
    class LandingPage
    {

        [FindsBy(How = How.Id, Using = "run-button")]
        private IWebElement runButton;

        [FindsBy(How = How.Id, Using = "output")]
        private IWebElement outputBox;

        [FindsBy(How = How.Id, Using = "login-modal-label")]
        private IWebElement logInModalHeader;

        [FindsBy(How = How.CssSelector, Using = ".nuget-panel > input")]
        private IWebElement nuGetInput;

        [FindsBy(How = How.ClassName, Using = ".package-name")]
        private IWebElement nuGetPackageList;

        [FindsBy(How = How.Id, Using = "Share")]
        private IWebElement shareButton;

        [FindsBy(How = How.Id, Using = "ShareLink")]
        private IWebElement shareText;

        [FindsBy(How = How.ClassName, Using = "glyphicon-chevron-left")]
        private IWebElement closeOptionsButton;

        [FindsBy(How = How.Id, Using = "save-button")]
        private IWebElement saveButton;

        [FindsBy(How = How.LinkText, Using = "/GettingStarted/")]
        private IWebElement gettingStartedButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='top - navbar']/*/span[contains(text(),'Back To Editor')]")]
        private IWebElement backToEditorButton;

        public void run()
        {
            runButton.Click();
        }

        public string verifyOutputText()
        {
            string output = outputBox.Text;
            return output;
        }

        public void selectNuGetPackage()
        {
            nuGetInput.SendKeys("nUnit");
            nuGetInput.FindElement(By.XPath("//*[@id='menu']/li/a/span[contains(text(), 'NUnit')]")).Click();
            nuGetInput.FindElement(By.XPath("//*[@id='menu']/li[1]/ul/li[1]/a")).Click();
        }

        public string getNuGetPackage()
        {
            string packageName = nuGetPackageList.Text;
            return packageName;
        }

        public void share()
        {
            shareButton.Click();
        }

        public string getShareLink()
        {
            string linkText = shareText.GetAttribute("value");
            return linkText;
        }

        public void closeOptions()
        {
            closeOptionsButton.Click();
        }

        public void save()
        {
            saveButton.Click();
        }

        public void getStarted()
        {
            gettingStartedButton.Click();
        }

        public void backToEditor()
        {
            backToEditorButton.Click();
        }

    }
}
