using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands.Company.UpdateCompany
{
    public sealed record UpdateCompanyCommandResponse(
    string Message = "Şirket kaydı başarıyla güncellendi");
}
