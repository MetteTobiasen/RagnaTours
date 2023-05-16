using RagnaTours.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using RagnaTours;
using RagnaTours.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RagnaToursXUnitTest.Unit_Test.ExhibitionTest
{
    public class GetAllExhibitionsUnitTest
    {
        private readonly Mock<IExhibitionRepository> mockRepo;
        private readonly GetAllExhibitionsModel getAllExhibitionsModel;

        public GetAllExhibitionsUnitTest () 
        { 
            mockRepo = new Mock<IExhibitionRepository>();
            getAllExhibitionsModel = new GetAllExhibitionsModel (mockRepo.Object);  
        }

        [Fact]
        public void OnGet_ReturnsIActionResult_WithADictionaryOfExhibitions()
        {
            //Arange
            mockRepo.Setup(mockRepo => mockRepo.AllExhibition()).Returns(GetTestExhibitions());

            //Act
            var result = getAllExhibitionsModel.OnGet();
            Dictionary<int, Exhibition> myDictionary = getAllExhibitionsModel.Exhibitions;

            //Assert 
            Assert.IsAssignableFrom<IActionResult>(result);
            var viewResult = Assert.IsType<PageResult>(result);
            var actualMessages = Assert.IsType<Dictionary<int, Exhibition>>(myDictionary);
            Assert.Equal(2, myDictionary.Count);
            Assert.Equal("Fast Udstilling", myDictionary[0].Name);
            Assert.Equal("Roskilde Festival", myDictionary[1].Name);
            
        }

        private Dictionary<int, Exhibition> GetTestExhibitions()
        {
            var exhibitions = new Dictionary<int, Exhibition>
            {
                { 
                    1, new Exhibition
                    {
                        Id = 1,
                        Name = "Fast Udstilling",
                        Description = "Test Test Test",
                        ImageName = "FastUdstilling"
                    } 
                },
                {  
                    2, new Exhibition
                    {
                        Id = 2,
                        Name = "Roskilde Festival",
                        Description = "Test Test Test",
                        ImageName = "RoskildeFestivalUdstilling"
                    }
                } 
            };

            return exhibitions;
        }
    }
}

