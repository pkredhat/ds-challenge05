## Challenge-05

### Scenario
* Lets continue to built on top of ds-challenge-04
* When you start the workspace, it will take sometime because all libraries are being downloaded as a part of the "postStart" event in the devfile. The subsequent restarts will happen quicker.
* This section will explore on adding more extensions in consistent way and also debugging code.

### Set Up + verification
* Run the dotnet application using commands "2. Build" from devfile like you did in the previous lab(s)
* Open a new terminal and execute below command. The response from the method has an error. The fifth character is "S" but it is returning "h"
  ```bash
  curl localhost:5154/api/challenge
  ```
* Open the "/Controllers/DSChallenge05Controller.cs" and inspect the method challengeMethod()
* Try to put a breakpoint and you realize that they do not work and or a way to do it
* Find out what extension is required for adding breakpoints. Include the required line in the file ".vscode/extensions.json"
* Once you update the extensions.json, restart your workspace (This time it will be quicker). Now you should be able to put a breakpoint in the challengeMethod()
* Rerun the dotnet application using command "2. Build". 
* You can now use the "Run & Debug" from the navigation. You may get prompted to Restore the file or install any missing components, click yes and/or restore to these prompts.
* Now fix the code, execute below command and ensure you are seeing "The Fifth Chatacter in the word "OpenShift"=[S]"
  ```bash
  curl localhost:5154/api/challenge
  ```

### Success Criteria
* ".vscode/extensions.json" is updated with the required debug extension
* You have used the debugger to fix the challengeMethod() in "/Controllers/DSChallenge05Controller.cs"

### Resources 
* https://go.microsoft.com/fwlink/?LinkId=827846

### What did we learn?
* OpenShift DevSpaces reduces the Developers pain points. As a Developer, your life is getting simpler with the below
    * Automatic provisioning of required command line tools
    * Consistent way of building, packaging and running the programs making faster iterative development
    * Consistent way of creating standardized end points for current and future testing
    * You can request additional resources easily similar to any workload in the kubernetes without the need for traditional hardware refreshes and or needing to require a compelete setup on brand new infrastructure
    * Add events to your IDE which can allow to do tasks before start, after start or after stop    
* Added to it, the core feature of debugging the code is also similar to your IDEs that you use daily
* BIG TAKEAWAY
    * OpenShift DevSpaces (With IDE as Code approach) works similar to your IDEs
    * The above mentioned benefits enhance the developers joy
