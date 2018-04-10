using System.Threading;
using System.Windows.Forms;
using NUnit.Framework;
using Page.Basic;
using Page.Desktop;
using Page.Login;

namespace ClassLibrary1
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

            string [] amountLeftBefore = {PageBase.Map.TerritoriesLeftAmount.Text};

            PageBase.Map.CheckBoxTaskLeft.Click();
            PageBase.Map.TaskToSyncButton.Click();

            PageHelper.WaitForMap(() => PageBase.Map.CheckBoxTaskRight);
            PageBase.Map.InformationRefresher.Click();
            Thread.Sleep(2000);

            string[] amountLeftAfter = { PageBase.Map.TerritoriesLeftAmount.Text };
            Assert.AreNotEqual(amountLeftBefore,amountLeftAfter);
        }

        protected override string PageUrl => "calendar#/calendar";
    }
}
