using MediatorDemo.Library.Models;
using MediatR;

namespace MediatorDemo.Library.Queries
{
    public record GetStudentByIdQuery(int id):IRequest<StudentModel>;
  
}
