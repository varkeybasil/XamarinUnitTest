using System;
using System.Globalization;
using AutoMoqCore;
using FluentAssertions;
using UnitTestForms.ViewModels;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           //Arrange
            var autoMoq = new AutoMoqer();
            var cultureInfo = new CultureInfo("en-GB");
            autoMoq.SetInstance(cultureInfo);

            //Act
            var aboutViewModel =   autoMoq.Create<AboutViewModel>();
            aboutViewModel.OpenWebCommand.Execute(null);
            
            //Assert
            //aboutViewModel.Title.CompareTo("About");
            //Assert.Equal(aboutViewModel.Title,"About");
            aboutViewModel.TestMe.Should().BeTrue();
            // aboutViewModel.OpenWebCommand.Execute(null);
        }

        [Fact]
        public void Test2()
        {
            //Arrang3
            var autoMoq = new AutoMoqer();
            var cultureInfo = new CultureInfo("en-GB");
            autoMoq.SetInstance(cultureInfo);

            //Act
            var aboutViewModel = autoMoq.Create<AboutViewModel>();
            aboutViewModel.TestMeFalseCommand.Execute(null);

            //Assert
            //aboutViewModel.Title.CompareTo("About");
            //Assert.Equal(aboutViewModel.Title,"About");
            aboutViewModel.TestMeString.Should().Be("Try this");
            // aboutViewModel.OpenWebCommand.Execute(null);
        }
    }
}
