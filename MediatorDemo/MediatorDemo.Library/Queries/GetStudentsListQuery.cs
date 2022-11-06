using MediatorDemo.Library.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo.Library.Queries
{
    public record GetStudentsListQuery():IRequest<List<StudentModel>>;
   
}
