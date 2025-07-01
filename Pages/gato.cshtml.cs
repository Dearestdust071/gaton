using Microsoft.AspNetCore.Mvc.RazorPages;
using gaton.Model;

namespace gaton.Pages;

public class GatoController : PageModel{

    public string jugador { get; set; }

    public void OnPost()
    {
        jugador = "X";
    }
}
