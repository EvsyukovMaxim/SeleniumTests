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

            PageHelper.WaitForMap(() => PageBase.Map.DropDownProjectArrow);
            PageBase.ClickProjectDropDownToOpen();

            var chooseProject = PageBase.Map.OpenedDropDownProjectTextBox;
            PageHelper.WaitUntilVisible(() => chooseProject);

            chooseProject.Clear();
            chooseProject.Click();
            chooseProject.SendKeys("Москва");
            SendKeys.SendWait("{ENTER}");

            var desktopPage = new DesktopPage();
            desktopPage.ValidateProject().UserProjectIs(PageBase.Map.DropDownProject.Text);

            PageBase.Map.CheckBoxTask.Click();
            PageBase.Map.TaskToSyncButton.Click();
        }

        protected override string PageUrl => "calendar#/calendar";
    }
}
