using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Drp.Data;
using Drp.Data.Entities;
using Drp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Tracker.Controllers
{
    [Route("api/SystemMenu")]
    public class SystemMenuController : EntityControllerBase<SystemMenu, SystemMenuReadModel, SystemMenuCreateModel, SystemMenuUpdateModel>
    {
        public SystemMenuController(DrpContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SystemMenuReadModel>> Get(CancellationToken cancellationToken, long id)
        {
            var readModel = await ReadModel(id, cancellationToken);

            if (readModel == null)
                return NotFound();

            return readModel;
        }

        [HttpGet("")]
        public async Task<ActionResult<IReadOnlyList<SystemMenuReadModel>>> List(CancellationToken cancellationToken)
        {
            var listResult = await QueryModel(null, cancellationToken);
            return Ok(listResult);
        }

        [HttpPost("")]
        public async Task<ActionResult<SystemMenuReadModel>> Create(CancellationToken cancellationToken, SystemMenuCreateModel createModel)
        {
            var readModel = await CreateModel(createModel, cancellationToken);

            return readModel;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SystemMenuReadModel>> Update(CancellationToken cancellationToken, long id, SystemMenuUpdateModel updateModel)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            if (readModel == null)
                return NotFound();

            return readModel;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SystemMenuReadModel>> Delete(CancellationToken cancellationToken, long id)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            if (readModel == null)
                return NotFound();

            return readModel;
        }

    }
}
