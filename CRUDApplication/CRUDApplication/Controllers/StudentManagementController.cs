using CRUDApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUDApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentManagementController : ControllerBase
    {
        private readonly DataContext dataContext;

        public StudentManagementController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        [Route("GetStudents")]
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await dataContext.Students.ToListAsync();
        }
        [HttpGet]
        [Route("GetStudent/{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await dataContext.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(student);
            }
        }

        [HttpPost]
        [Route("AddStudent")]
        public async Task<Student> AddStudent(Student objStudent)
        {
            dataContext.Students.Add(objStudent);
            await dataContext.SaveChangesAsync();
            return objStudent;
        }

        [HttpPatch]
        [Route("UpdateStudent/{id}")]
        public async Task<Student> UpdateStudent(Student objStudent)
        {
            dataContext.Entry(objStudent).State = EntityState.Modified;
            await dataContext.SaveChangesAsync();
            return objStudent;
        }

        [HttpDelete]
        [Route("DeleteStudent/{id}")]
        public bool DeleteStudent(int id)
        {
            bool result = false;
            var student = dataContext.Students.Find(id);
            if (student != null) 
            {
                result = true;
                dataContext.Entry(student).State = EntityState.Deleted;
                dataContext.SaveChanges();
            }
            else
            {
                result = false;
            }

            return result;
        }
        //Teachers
        [HttpGet]
        [Route("GetTeachers")]
        public async Task<IEnumerable<Teacher>> GetTeachers()
        {
            return await dataContext.Teachers.ToListAsync();
        }
        [HttpGet]
        [Route("GetTeacher/{id}")]
        public async Task<ActionResult<Teacher>> GetTeacher(int id)
        {
            var teacher = await dataContext.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(teacher);
            }
        }

        [HttpPost]
        [Route("AddTeacher")]
        public async Task<Teacher> AddTeacher(Teacher objTeacher)
        {
            dataContext.Teachers.Add(objTeacher);
            await dataContext.SaveChangesAsync();
            return objTeacher;
        }

        [HttpPatch]
        [Route("UpdateTeacher/{id}")]
        public async Task<Teacher> UpdateTeacher(Teacher objTeacher)
        {
            dataContext.Entry(objTeacher).State = EntityState.Modified;
            await dataContext.SaveChangesAsync();
            return objTeacher;
        }

        [HttpDelete]
        [Route("DeleteTeacher/{id}")]
        public bool DeleteTeacher(int id)
        {
            bool result = false;
            var teacher = dataContext.Teachers.Find(id);
            if (teacher != null)
            {
                result = true;
                dataContext.Entry(teacher).State = EntityState.Deleted;
                dataContext.SaveChanges();
            }
            else
            {
                result = false;
            }

            return result;
        }

        //Subjects
        [HttpGet]
        [Route("GetSubjects")]
        public async Task<IEnumerable<Subject>> GetSubject()
        {
            return await dataContext.Subjects.ToListAsync();
        }
        [HttpGet]
        [Route("GetSubject/{id}")]
        public async Task<ActionResult<Subject>> GetSubject(int id)
        {
            var subject = await dataContext.Subjects.FindAsync(id);
            if (subject == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(subject);
            }
        }

        [HttpPost]
        [Route("AddSubject")]
        public async Task<Subject> AddSubject(Subject objSubject)
        {
            dataContext.Subjects.Add(objSubject);
            await dataContext.SaveChangesAsync();
            return objSubject;
        }

        [HttpPatch]
        [Route("UpdateSubject/{id}")]
        public async Task<Subject> UpdateSubject(Subject objSubject)
        {
            dataContext.Entry(objSubject).State = EntityState.Modified;
            await dataContext.SaveChangesAsync();
            return objSubject;
        }

        [HttpDelete]
        [Route("DeleteSubject/{id}")]
        public bool DeleteSubject(int id)
        {
            bool result = false;
            var subject = dataContext.Subjects.Find(id);
            if (subject != null)
            {
                result = true;
                dataContext.Entry(subject).State = EntityState.Deleted;
                dataContext.SaveChanges();
            }
            else
            {
                result = false;
            }

            return result;
        }

        //Classrooms
        [HttpGet]
        [Route("GetClassrooms")]
        public async Task<IEnumerable<ClassRoom>> GetClassroom()
        {
            return await dataContext.ClassRooms.ToListAsync();
        }
        [HttpGet]
        [Route("GetClassroom/{id}")]
        public async Task<ActionResult<ClassRoom>> GetClassroom(int id)
        {
            var classroom = await dataContext.ClassRooms.FindAsync(id);
            if (classroom == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(classroom);
            }
        }

        [HttpPost]
        [Route("AddClassroom")]
        public async Task<ClassRoom> AddClassroom(ClassRoom objClassroom)
        {
            dataContext.ClassRooms.Add(objClassroom);
            await dataContext.SaveChangesAsync();
            return objClassroom;
        }

        [HttpPatch]
        [Route("UpdateClassroom/{id}")]
        public async Task<ClassRoom> UpdateClassroom(ClassRoom objClassroom)
        {
            dataContext.Entry(objClassroom).State = EntityState.Modified;
            await dataContext.SaveChangesAsync();
            return objClassroom;
        }

        [HttpDelete]
        [Route("DeleteClassroom/{id}")]
        public bool DeleteClassroom(int id)
        {
            bool result = false;
            var classroom = dataContext.ClassRooms.Find(id);
            if (classroom != null)
            {
                result = true;
                dataContext.Entry(classroom).State = EntityState.Deleted;
                dataContext.SaveChanges();
            }
            else
            {
                result = false;
            }

            return result;
        }

        [HttpGet]
        [Route("GetAllocatedSubjects")]
        public async Task<IEnumerable<AllocateSubject>> GetSubjectAllocations()
        {
            return await dataContext.AllocateSubjects.ToListAsync();
        }
        [HttpPost]
        [Route("AllocateSubject")]
        public async Task<AllocateSubject> allocateSubject(AllocateSubject objAllocatesubject)
        {
            dataContext.AllocateSubjects.Add(objAllocatesubject);
            await dataContext.SaveChangesAsync();
            return objAllocatesubject;
        }

        [HttpGet]
        [Route("GetAllocatedClassrooms")]
        public async Task<IEnumerable<AllocateClassRoom>> GetClassroomAllocation()
        {
            return await dataContext.AllocateClassRooms.ToListAsync();
        }
        [HttpPost]
        [Route("AllocateClassroom")]
        public async Task<AllocateClassRoom> allocateClassroom(AllocateClassRoom objAllocateClassroom)
        {
            dataContext.AllocateClassRooms.Add(objAllocateClassroom);
            await dataContext.SaveChangesAsync();
            return objAllocateClassroom;
        }
    }
}
