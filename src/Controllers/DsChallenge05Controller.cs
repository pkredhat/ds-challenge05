using Microsoft.AspNetCore.Mvc;

namespace ds_challenge_05.Controllers;


[ApiController]
[Route("api/challenge")]
public class ChallengeMethodController : ControllerBase
{
    [HttpGet(Name = "ChallengeMethod")]
    public string ChallengeMethod()
    {
        string name = "OpenShift DevSpaces";
        int length = name.Length;

        for (int index = 0; index < length; index++)
        {
            char indexChar = name[index];
            if (index == 4) // Index 4 is the fifth character in a zero-based index system
            {
                char fifthCharacter = indexChar;
                return $"The Fifth Character in the word \"OpenShift\"=[{fifthCharacter}]\n";
            }
        }

        return "String is shorter than length 5 \n";
    }
}