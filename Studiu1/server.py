from flask import Flask, render_template, request, jsonify
import json
import os

server = Flask(__name__)

@server.route('/')
def index():
    return render_template('index.html')

@server.route('/contact')
def contact():
    return render_template('contact.html')

UPLOAD_FOLDER = 'uploads'
os.makedirs(UPLOAD_FOLDER, exist_ok=True)

@server.route('/submit_contact_form', methods=['POST'])
def submit_contact_form():
    # Preia datele din formular (textuale)
    name = request.form.get('name')
    email = request.form.get('email')
    phone = request.form.get('phone')
    newsletter = request.form.get('newsletter')
    contact_method = request.form.get('contact_method')
    category = request.form.get('category')

    # Preia fișierul încărcat
    uploaded_file = request.files.get('file_upload')
    file_path = None

    # Dacă există fișier, îl salvăm pe server
    if uploaded_file and uploaded_file.filename != '':
        file_path = os.path.join(UPLOAD_FOLDER, uploaded_file.filename)
        uploaded_file.save(file_path)

    # Crează un obiect JSON cu datele formularului
    data = {
        'name': name,
        'email': email,
        'phone': phone,
        'newsletter': newsletter,
        'contact_method': contact_method,
        'category': category,
        'file_path': file_path  # Adăugăm calea fișierului încărcat
    }

    # Numele fișierului JSON pentru a stoca datele
    json_file = 'contact_data.json'

    # Verifică dacă fișierul JSON există și are conținut
    if not os.path.exists(json_file) or os.stat(json_file).st_size == 0:
        with open(json_file, 'w') as f:
            json.dump([], f)

    # Citește și actualizează datele din fișierul JSON
    with open(json_file, 'r+') as f:
        try:
            existing_data = json.load(f)  # Încarcă datele existente
        except json.JSONDecodeError:
            existing_data = []  # În caz de eroare de decodare, folosim o listă goală

        # Adaugă datele noi
        existing_data.append(data)
        
        # Mergem la începutul fișierului și salvăm datele actualizate
        f.seek(0)
        json.dump(existing_data, f, indent=4)
        f.truncate()  # Truncatează orice conținut rămas după adăugarea noilor date

    # Răspunde cu un mesaj de succes
    return jsonify({'message': 'Form submitted successfully'})
"""
@server.route('/submit_contact_form', methods=['POST'])
def submit_contact_form():
    data = request.json
    json_file = 'contact_data.json'

    if not os.path.exists(json_file) or os.stat(json_file).st_size == 0:
        with open(json_file, 'w') as f:
            json.dump([], f)

    with open(json_file, 'r+') as f:
        try:
            existing_data = json.load(f)  
        except json.JSONDecodeError:
            existing_data = []  

        existing_data.append(data) 
        f.seek(0)
        json.dump(existing_data, f, indent=4)
        f.truncate()  

    return jsonify({'message': 'Form submitted successfully'})
"""
if __name__ == '__main__':
    server.run(debug=True)
