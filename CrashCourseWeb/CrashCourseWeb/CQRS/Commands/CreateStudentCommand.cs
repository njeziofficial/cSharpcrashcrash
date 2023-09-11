using CrashCourseWeb.Data;
using CrashCourseWeb.Models;
using MediatR;

namespace CrashCourseWeb.CQRS.Commands
{
    public class CreateStudentCommand : Student, IRequest<Student>
    {

    }

    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Student>
    {
        private readonly ApplicationContext _context;

        public CreateStudentCommandHandler(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Student> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
        {
            var response = (await _context.Students.AddAsync(command)).Entity;
            await _context.SaveChangesAsync();
            return response;
        }
    }
}
