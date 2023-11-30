require "io/console"

$stack = []

def push(e); $stack << e; end
def pop; $stack.pop; end
def add(n); push(pop + n); end

def convicted_of; push(0); end
def homocide; add(20); end
def arson; add(10); end
def bookmaking; add(2); end
def tax_evasion; add(5); end

def will_serve; print " #{pop} years."; end

def spinner(duration, interval=0.1)
  spinner_chars = ['|', '/', '-', '\\']
  end_time = Time.now + duration

  while Time.now < end_time
    spinner_chars.each do |char|
      print "\r#{char}"
      $stdout.flush
      sleep(interval)
    end
  end
end

def get_input(prompt)
  print prompt

  line = ""
  while char = STDIN.getch
    case char
    when "\r", "\n"
      yield line
      # spinner(2)
      sleep 2
      print " ok.\n"
      break
    else
      line << char
      print char
    end
  end
  
  line
end

def start
  puts "*** Judge.ly - welcome home you sadistic fuck! ***"
  catch(:quit!) do
    loop do
      get_input("> ") do |line|
        line.split(" ").each do |cmd|
          case cmd
          when /convicted/i then convicted_of
          when /homocide/i then homocide
          when /arson/i then arson
          when /bookmaking/i then bookmaking
          when /tax/i then tax_evasion
          when /serve/i then will_serve
          when /quit/i then throw(:quit!)
          end
        end
      end
    end
  end
  puts "\nBye!"
  abort
end

start

