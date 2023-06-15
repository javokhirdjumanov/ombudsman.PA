﻿using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services;

namespace Ombudsman.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ManualController : ControllerBase
{
    private readonly IManualService manualService;
    public ManualController(IManualService manualService)
    {
        this.manualService = manualService;
    }
    [HttpGet]
    public IActionResult NormativeDocumentTypesSelectList()
    {
        var normativeDocs = this.manualService
            .NormativeDocumentTypesSelectList();

        return Ok(normativeDocs);
    }
    [HttpGet]
    public IActionResult PerformerTypesSelectList()
    {
        var performerType = this.manualService
            .PerformerTypesSelectList();

        return Ok(performerType);
    }
    [HttpGet]
    public IActionResult StateOrganizationSelectList()
    {
        var stateOrg = this.manualService
            .StateOrganizationSelectList();

        return Ok(stateOrg);
    }
    [HttpGet]
    public IActionResult StatusSelectList()
    {
        var statuses = this.manualService
            .StatusSelectList();

        return Ok(statuses);
    }
    [HttpGet]
    public IActionResult InitiativeTypesSelectList()
    {
        var initiativeTypes = this.manualService
            .InitiativeTypesSelectList();

        return Ok(initiativeTypes);
    }
    [HttpGet]
    public IActionResult DocumentStatusSelectList()
    {
        var documentStatus = this.manualService.DocumentStatusSelectList();

        return Ok(documentStatus);
    }
    [HttpGet]
    public IActionResult DocumentImportanceSelectList()
    {
        var documentImportance = this.manualService.DocumentImportanceSelectList();

        return Ok(documentImportance);
    }
}
