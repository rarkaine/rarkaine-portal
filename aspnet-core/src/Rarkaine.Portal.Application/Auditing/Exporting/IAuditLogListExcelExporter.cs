using System.Collections.Generic;
using Rarkaine.Portal.Auditing.Dto;
using Rarkaine.Portal.Dto;

namespace Rarkaine.Portal.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
