using System.Collections.Generic;
using Abp;
using Rarkaine.Portal.Chat.Dto;
using Rarkaine.Portal.Dto;

namespace Rarkaine.Portal.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
