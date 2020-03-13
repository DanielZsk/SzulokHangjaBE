using NUnit.Framework;
using NSubstitute;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using SzulokHangjaBE.Data;
using SzulokHangjaBE.Controllers;
using SzulokHangjaBE.Models.UserPosts;
using SzulokHangjaBE.Services;

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
            var filterMock = Substitute.For<FilterPosts<ParentPost>>(contextMock);
            var parentController = new ParentPostsController(contextMock, filterMock);
            // from online example: var actual = await _articleRepository.GetById(articleId);
            var result = await parentController.GetAllParentPosts();
            var expected = 2;
            
            Assert.AreEqual(expected, result);
        }
    }
}