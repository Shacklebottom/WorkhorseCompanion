As I progressed as a programmer, the number of discrete Solutions piled up. It became a hassle to add, manage, and work on them, old and new. To that end I created the Workhorse Companion, an application that manages the tasks I encounter regularly to semi-regularly. Tasks such as:

Creating a new Solution,
Opening a Solution,
Version Control using Git to Git:
 * Init, Commit, Status, open the Git terminal, etc.

Since the application couldn't do just that, I added a few other things to round out the usefulness of it:

* A ticket system that aims at keeping track of the issues, inconsistencies, and future additions that belong to a given Solution.

* A journal system where I can place my thoughts, intentions, and impressions for a given Solution. When a journal entry is submitted, the number of commits and the number of lines of code are also recorded (with whitespace and lines where the character count is less than 4 omitted). This is so that I may see how an initiative has changed over time.

* A documentation tracker that houses universal documentation (such as .NET's documentation). 

* and a secondary tracker for "resources" that are for a given Solution, such as internal Images and Documents, and external Websites.

  * The Workhorse stores information locally, and moves internal documentation to its ProjectTracking folder (rooted at the C: drive).

---

Praise:

* I love this little guy. I use it almost every day. It's taken the forefront of my workflow by centralizing several facets of the creation process into something akin to a diamond. It saves me valuable time by reducing keystrokes, decreasing distraction, and keeping track of relevant articles. I love it so much that I colored it and refactored the UI to make it as efficient as possible.

Criticism:

* If I were to start over, I think I'd try an attempt at being cognizant of how many repeating forms I have. Many of the forms could be just one form that changes its layout depending on what was passed to it at creation.
* Aspects of the application are hardcoded, such as:
    * The application assumes you are not only using Visual Studio for a given project, but that you're also using the default install path. 
    * When creating a new (blank) Solution -- the HeaderInfo obj has values that could potentially change at any time.
    * The application assumes you are using the default install path for git-bash.
    * The AppDirectory class needs a major refactor, and has default install paths that suit my personal needs.
