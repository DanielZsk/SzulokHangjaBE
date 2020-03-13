using NUnit.Framework;
using NSubstitute;
using SzulokHangjaBE.Data;
using SzulokHangjaBE.Controllers;
using Microsoft.EntityFrameworkCore;
using SzulokHangjaBE.Models.UserPosts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SzulokHangjaBETests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task ListallControllerReturnsRightNumberOfObjects()
        {
            var options = new DbContextOptionsBuilder<SzulokHangjaBEContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
                .Options;
            var contextMock = Substitute.For<SzulokHangjaBEContext>(options);
            var parentController = new ParentPostsController(contextMock);
            // from online example: var actual = await _articleRepository.GetById(articleId);
            var result = await parentController.GetAllParentPosts();
            var expected = 2;
            
            Assert.AreEqual(expected, result);
        }
    }
}