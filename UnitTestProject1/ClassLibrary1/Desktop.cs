using System.Windows.Forms;
using NUnit.Framework;
using Page.Basic;
using Page.Desktop;
using Page.Login;

namespace UnitTestProject1
{
    [TestFixture]
    public class Desktop : WebDriverTestsBase<DesktopPage>
    {
        [Test]
        public void ChooseProject()
        {
            if (!PageBase.IsAuthorized)
            {
                var loginPage = new LoginPage();
                loginPage.FillAuthForm("local\\b", "b");
                loginPage.ClickLoginButton();
                PageHelper.WaitForMap(() => PageBase.Map.UserNameDiv);
                loginPage.Validate().UserNameIs("b");
            }
            WebDriverContext.Navigate("calendar#/calendar/");
            PageBase.ClickDropDownProject();
            var chooseProject = PageBase.Map.DropDownProjectTextBox;
            PageHelper.WaitUntilVisible(() => chooseProject);
            //chooseProject.Clear();
            chooseProject.Click();
            //chooseProject.SendKeys("Москва");
            //SendKeys.Send("{ENTER}");
            //StringAssert.Contains(PageBase.Map.DropDownShort.Text, chooseProject.Text,"The results DIV doesn't contains the specified text.");
        }

        protected override string PageUrl => "calendar#/calendar";
    }
}
