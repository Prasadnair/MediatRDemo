using MediatorDemo.Library.Data;
using MediatorDemo.Library.Models;
using MediatorDemo.Library.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo.Library.Handlers
{
    public class GetStudentsListHandler : IRequestHandler<GetStudentsListQuery, List<StudentModel>>
    {
        private readonly IDataRepository _repository;

        public GetStudentsListHandler(IDataRepository repository)
        {
            this._repository = repository;
        }

        public Task<List<StudentModel>> Handle(GetStudentsListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(this._repository.GetStudents());
        }
    }
}
