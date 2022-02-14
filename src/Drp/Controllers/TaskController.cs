﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Drp.Data;
using Drp.Data.Entities;
using Drp.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Task = Drp.Data.Entities.Task;

namespace Tracker.Controllers
{
    [Route("api/Task")]
    public class TaskController : EntityControllerBase<Task, TaskReadModel, TaskCreateModel, TaskUpdateModel>
    {
        public TaskController(DrpContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskReadModel>> Get(CancellationToken cancellationToken, Guid id)
        {
            var readModel = await ReadModel(id, cancellationToken);

            if (readModel == null)
                return NotFound();

            return readModel;
        }

        [HttpGet("")]
        public async Task<ActionResult<IReadOnlyList<TaskReadModel>>> List(CancellationToken cancellationToken)
        {
            var listResult = await QueryModel(null, cancellationToken);
            return Ok(listResult);
        }

        [HttpPost("")]
        public async Task<ActionResult<TaskReadModel>> Create(CancellationToken cancellationToken, TaskCreateModel createModel)
        {
            var readModel = await CreateModel(createModel, cancellationToken);

            return readModel;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TaskReadModel>> Update(CancellationToken cancellationToken, Guid id, TaskUpdateModel updateModel)
        {
            var readModel = await UpdateModel(id, updateModel, cancellationToken);
            if (readModel == null)
                return NotFound();

            return readModel;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TaskReadModel>> Delete(CancellationToken cancellationToken, Guid id)
        {
            var readModel = await DeleteModel(id, cancellationToken);
            if (readModel == null)
                return NotFound();

            return readModel;
        }

    }
}
