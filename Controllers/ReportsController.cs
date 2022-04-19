#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsReportAPIService.Data;
using NewsReportAPIService.Models;

namespace NewsReportAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly NewsReportAPIServiceContext _context;

        public ReportsController(NewsReportAPIServiceContext context)
        {
            _context = context;
        }

/*        // GET: api/Reports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Report>>> GetReport()
        {	
		    return await _context.Report.ToListAsync();

        }
*/

        // GET: api/Reports
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Report>>> GetReport(Guid? guid, int? category = 0, bool desc = true)
        {	
        
        	    var guidIsEmpty = (guid == null || guid.Value == Guid.Empty);
	  	

			// Baseline for select for the reports	  		
			var reports = from r in _context.Report
					   select r;	  		
					   
			// The search should be ordered by updateddate descending 
			if (desc) 
			{
				reports = reports.OrderByDescending(s => s.UpdatedDate);
			}
	  	
	  	
        	    if (category == 0)
        	    {
        	    	if (!guidIsEmpty)
        	    	{
        	    		reports = reports.Where(x => x.CreatedBy == guid);
			    	//return await _context.Report.Where(x => x.CreatedBy == guid).ToListAsync();        	    
			}
			else
			{
			    	//return await _context.Report.OrderByDescending(s => s.UpdatedDate).ToListAsync();        	    			
			}
		    }
		    else{
   		        Report.CategoryType cat = (Report.CategoryType)category;  

			if (!guidIsEmpty)
			{
				 	reports = reports.Where(x => x.Category == cat & x.CreatedBy == guid); 	
				    //return await _context.Report.Where(x => x.Category == cat & x.CreatedBy == guid).ToListAsync();
			}
			else
			{
					reports = reports.Where(x => x.Category == cat); 	
				  // return await _context.Report.Where(x => x.Category == cat).ToListAsync();			
		    	}
		    }
		    
		    return await reports.ToListAsync();
		    
		    
/*		    	if (category != 0 && !guidIsEmpty)
			    {
				    Report.CategoryType cat = (Report.CategoryType)category;  
				    return await _context.Report.Where(x => x.Category == cat & x.CreatedBy == guid).ToListAsync();
			    }
			   
			    if (category != 0)
			    {
				    Report.CategoryType cat = (Report.CategoryType)category;  
				    return await _context.Report.Where(x => x.Category == cat).ToListAsync();
			    }
			    
			    if (!guidIsEmpty)
			    {
				    Report.CategoryType cat = (Report.CategoryType)category;  
				    return await _context.Report.Where(x => x.CreatedBy == guid).ToListAsync();
			    }
			   return await _context.Report.ToListAsync();        
*/			    
        }


        // GET: api/Reports/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Report>> GetReport(int id)
        {
            var report = await _context.Report.FindAsync(id);

            if (report == null)
            {
                return NotFound();
            }

            return report;
        }

        // PUT: api/Reports/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReport(int id, Report report)
        {
            if (id != report.Id)
            {
                return BadRequest();
            }
            
            var report_orig = await _context.Report.FindAsync(id);
            
            report_orig.Title = report.Title;
            report_orig.Content = report.Content;
            report_orig.Category = report.Category;
            
            if (!report_orig.IsPublished && report.IsPublished)
            {
            	report_orig.PublishedDate = DateTime.Now;
            	report_orig.IsPublished = true;
            }

            report_orig.UpdatedDate = DateTime.Now;
            

            _context.Entry(report_orig).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReportExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Reports
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Report>> PostReport(Report report)
        {
            if (report.IsPublished) report.PublishedDate = DateTime.Now;
            report.CreatedDate = DateTime.Now;
            report.UpdatedDate = DateTime.Now;

            _context.Report.Add(report);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReport", new { id = report.Id }, report);
        }

        // DELETE: api/Reports/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReport(int id)
        {
            var report = await _context.Report.FindAsync(id);
            if (report == null)
            {
                return NotFound();
            }

            _context.Report.Remove(report);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReportExists(int id)
        {
            return _context.Report.Any(e => e.Id == id);
        }
    }
}
