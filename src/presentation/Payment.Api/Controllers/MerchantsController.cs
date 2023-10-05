using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Payment.Application.Base.Models;
using Payment.Application.Features.Merchant.Commands;

namespace Payment.Api.Controllers
{
    /// <summary>
    /// API for CRUD Merchant
    /// </summary>
    [Route("api/merchants")]
    [ApiController]
    public class MerchantsController : ControllerBase
    {
        /// <summary>
        /// Get Merchant base on criteria
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get(string criteria)
        {
            return Ok();
        }

        /// <summary>
        /// Get Merchant with pagination
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("with-paging")]

        public IActionResult GetPaging([FromQuery] BasePagingQuery query)
        {
            return Ok();
        }

        /// <summary>
        /// Get Merchant by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetOne([FromQuery] string id)
        {
            return Ok();
        }

        /// <summary>
        /// Create Merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] CreateMerchant request)
        {
            return Ok();
        }

        /// <summary>
        /// Update Merchant
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{Id}")]
        public IActionResult Update(string id, [FromBody] UpdateMerchant request)
        {
            return Ok();
        }

        /// <summary>
        /// Set active Merchant
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{Id}/set-active")]
        public IActionResult SetActive(string id, [FromBody] UpdateMerchant request)
        {
            return Ok();
        }

        /// <summary>
        /// Delete Merchant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{Id}")]
        public IActionResult Delete(string id)
        {
            return Ok();
        }
    }
}
