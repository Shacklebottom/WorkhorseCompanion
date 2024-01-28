using TestHarness;

Logger.Log("===>TURTLES ENGAGE<===");

/*
 * ||Workplace Companion||
 * 
 * Vision:
 * Private Companion for tracking your own workplace/project statistics.
 * 
 * Features:
 * 
 * Project Time Tracking
 * Time Adjuster with _required_ note
 * Project Task Tracking
 * Open Folder containing Project
 * Open Bash to Folder (with toggle)
 * Standard Alarm (with breakmode toggle)
 * Pomodoro Alarm and Idle
 * "Don't Forget" Alarm(s)
 * 
 * 
 * Foreseen Design Requirements:
 * 
 * Button to add a new project.
 * Dropdown to select a project for view.
 * Disable selection while a timer is running.
 * 
 * Button to set a folder for a project.
 * Button to open the set folder.
 * Checkbox to optionally open Bash at the set folder.
 * 
 * (alamer = alarm + timer)
 * Button to start tracking alamer.
 * Button to stop tracking alamer.
 * Time entry field to set the alamer.
 * Play alarm sound and display window.
 * Checkbox to toggle "breakmode."
 *      Time entry field to set breakmode. Begins after alarm's display window is "acknowledged."
 * Checkbox to toggle sound.
 * Dropdown to select played sound.
 * Display of total project time tracked.
 * 
 * Buttom to start Pomodoro alarm.
 * Button to stop Pomodoro alarm.
 * Dropdown to select Pomodoro pace (15 to 25 minutes active intervals, with 5 to 10 minute (range) inactive intervals.
 * 
 * Field that displays a list of current "Don't Forget" alarms.
 * A "Don't Forget" is a short description, remaining time, when it will go off, and optionally what sound it will make.
 * Button that adds a new alarm to the list.
 * Display window for a ringing alarm.
 * 
 * Checkbox to display logged time records.
 * Button displayed next to each logged time record that allows log edit.
 * Field that displays an initial message "write a short description for why this time was edited," 
 *      with a field displaying decrementing 100char count. (require at least "Forgot to click the timer" number of char).
 * 
 * Dropdown to select from Active or Complete tasks.
 * Button to create a new task.
 * Fields for entering a new task.
 *      Name entry field,
 *      Description entry field,
 *      Priority dropdown,
 *      Task Type dropdown.
 * A |Task| must be at least these things: 
 *      shortName (string), 
 *      taskDescription (string),
 *      Priority (enum), 
 *      taskType (enum), 
 *      Active (bool), 
 *      taskStart (DateTime), 
 *      taskEnd (DateTime).
 * Field displaying a list of interactable tasks and properties.
 * Field that displays the taskDescription when a task is clicked.
 * Button with "confirm" prompt to "flag" a selected task as complete.
 * Button to edit a selected task.
 * 
 */