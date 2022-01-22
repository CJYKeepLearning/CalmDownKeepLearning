from flask import Flask,render_template
app = Flask(__name__)
@app.route('/')
def hello() ->str:
    return 'Hello world from Flask!'
@app.route('/search')
def do_search()->str:
    return str(search('foling'))
@app.route('/entry')
def entry_page() -> 'html':
    return render_template('entry.html',
                           ten_title='Welcome')
app.run()
