
using Fiap.Web.Donation.Controllers;
using Fiap.Web.Donation.Models;
using Fiap.Web.Donation.Repository;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Fiap.Web.DonationTest
{
    public class ProdutoControllerTest
    {
        [Fact]
        public Task IndexReturnViewWithResult()
        {
            var mockProdutoRepository = new Mock<IProdutoRepository>();
            mockProdutoRepository.Setup(m => m.FindAllWithTipoOrderByName()).Returns(ListarProdutos3Mock());

            var controller = new ProdutoController(null, null, mockProdutoRepository.Object);

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);

            var model = Assert.IsAssignableFrom<IList<ProdutoModel>>(viewResult.ViewData.Model);

            Assert.NotEmpty(model);

            Assert.Equal(3, model.Count());

            return Task.CompletedTask;
        }



        [Fact]
        public Task IndexReturnViewWithoutResult()
        {
            var mockProdutoRepository = new Mock<IProdutoRepository>();
            mockProdutoRepository.Setup(m => m.FindAllWithTipoOrderByName()).Returns(new List<ProdutoModel>());

            var controller = new ProdutoController(null, null, mockProdutoRepository.Object);

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);

            var model = Assert.IsAssignableFrom<IList<ProdutoModel>>(viewResult.ViewData.Model);

            Assert.Empty(model);

            return Task.CompletedTask;
        }



        private IList<ProdutoModel> ListarProdutos3Mock()
        {
            return new List<ProdutoModel>
            {
                new ProdutoModel
                {
                    ProdutoId = 1,
                    Nome = "N1"
                },
                new ProdutoModel
                {
                    ProdutoId = 1,
                    Nome = "N1"
                },
                new ProdutoModel
                {
                    ProdutoId = 1,
                    Nome = "N1"
                },
            };
        }

    }
}